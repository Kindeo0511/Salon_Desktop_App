using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.Repository
{
    public class LoyaltyCardRepository
    {

        public IEnumerable<LoyaltyCardModel> GetLoyaltyCards() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT lr.reward_id, lr.service_id, sn.serviceName, lr.visit_required, lr.description FROM tbl_loyal_rewards lr
                            JOIN tbl_servicesname sn ON sn.serviceName_id = lr.service_id
                            ";
                return con.Query<LoyaltyCardModel>(sql);
            }
        }

        public bool Add(LoyaltyCardModel model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_loyal_rewards (service_id, visit_required, description)
                            VALUES (@service_id, @visit_required, @description)";
                return con.Execute(sql, model) > 0;
            }
        }

        public bool Update(LoyaltyCardModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_loyal_rewards 
                           SET service_id = @service_id,
                                visit_required = @visit_required,
                                description = @description
                            WHERE reward_id = @reward_id";
                return con.Execute(sql, model) > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_loyal_rewards WHERE reward_id = @id";
                return con.Execute(sql, id) > 0;
            }
        }

        public bool IsServiceExists(int id, int exclude_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_loyal_rewards WHERE service_id = @id AND reward_id != @exclude_id";
                return con.ExecuteScalar<int>(sql, new { id, exclude_id }) > 0;
            }
        }

        // tbl_loyalty card
        public int GetLastCardNumber() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_loyal_card WHERE Date(created_at) = CURDATE();";
                return con.ExecuteScalar<int>(sql);
            }
        }
        public bool CreateCustomerCard(int customer_id, string card_number) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_loyal_card (customer_id, card_number, created_at)
                            VALUES (@customer_id, @card_number, NOW())";
                return con.Execute(sql, new { customer_id, card_number }) > 0;
            }
        }

        public LoyaltyCardModel GetCardByCustomerId(int customer_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT CONCAT(ca.firstName,' ',ca.middleName,' ', ca.lastName) AS customer_name, lc.card_number, lc.created_at  FROM tbl_loyal_card lc  
                            JOIN tbl_customer_account ca On ca.customer_id = lc.customer_id
                            WHERE lc.customer_id = @customer_id";
                return con.QueryFirstOrDefault<LoyaltyCardModel>(sql,  new { customer_id });
            }
        }

        public List<LoyaltyCardModel> GetVisitProgress(int customer_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
    s.serviceName,
    COUNT(cv.visit_id)  AS visits,
    lr.visit_required   AS required,
    CAST(CASE 
        WHEN COUNT(cv.visit_id) >= lr.visit_required THEN 'FREE!'
        ELSE CONCAT(COUNT(cv.visit_id), '/', lr.visit_required, ' visits')
    END AS CHAR) AS progress
FROM tbl_loyal_rewards lr
JOIN tbl_servicesname s ON s.serviceName_id = lr.service_id
LEFT JOIN tbl_customer_visits cv ON cv.service_id = lr.service_id
    AND cv.card_id = (SELECT card_id FROM tbl_loyal_card 
                      WHERE customer_id = @customer_id)
    AND cv.is_free = 0
GROUP BY s.serviceName, lr.visit_required";
                return con.Query<LoyaltyCardModel>(sql, new { customer_id }).ToList();
            }
        }

    }
}
