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
        public bool IsVisitRequiredExists(int visit_required)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_loyal_rewards 
                    WHERE visit_required = @visit_required";
                return con.ExecuteScalar<int>(sql, new { visit_required }) > 0;
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
        public bool DeleteCardVisit(int card_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_customer_visits WHERE card_id = @card_id";
                return con.Execute(sql, new { card_id }) > 0;
            }
        }
        public bool DeleteCard(int card_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_loyal_card WHERE card_id = @card_id";
                return con.Execute(sql, new { card_id }) > 0;
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
                var sql = @"SELECT COALESCE(
                        MAX(CAST(SUBSTRING_INDEX(card_number, '-', -1) AS UNSIGNED)), 
                    0)
                    FROM tbl_loyal_card;";
                return con.ExecuteScalar<int>(sql);
            }
        }
        public bool IsCustomerHasCardNumber(int customer_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_loyal_card WHERE customer_id = @customer_id";
                return con.ExecuteScalar<int>(sql, new { customer_id }) > 0;
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
                var sql = @"SELECT CONCAT(ca.firstName,' ',ca.middleName,' ', ca.lastName) AS customer_name,lc.card_id, lc.card_number, lc.created_at  FROM tbl_loyal_card lc  
                            JOIN tbl_customer_account ca On ca.customer_id = lc.customer_id
                            WHERE lc.customer_id = @customer_id";
                return con.QueryFirstOrDefault<LoyaltyCardModel>(sql,  new { customer_id });
            }
        }
        public bool ShowButtonIfFree(int customer_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_customer_visits cv
                            JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
                            WHERE lc.customer_id = @customer_id AND  cv.is_free = 1;";
                return con.ExecuteScalar<int>(sql, new { customer_id }) > 0;
            }
        }
        public bool IsServiceMatchTotheCard(int service_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_loyal_rewards WHERE service_id = @service_id";
                return con.ExecuteScalar<int>(sql, new { service_id }) > 0;
            }
        }
        public List<LoyaltyCardModel> GetVisitProgress(int customer_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
    lr.visit_required,
    lr.service_id,
    s.serviceName,
    (SELECT COUNT(*) FROM tbl_customer_visits cv
     JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
     WHERE lc.customer_id = @customer_id
     AND cv.is_free = 0) AS total_visits,
    CAST(CASE 
        -- exactly hit OR exceeded milestone and not yet redeemed
        WHEN (SELECT COUNT(*) FROM tbl_customer_visits cv
              JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
              WHERE lc.customer_id = @customer_id
              AND cv.is_free = 0) >= lr.visit_required
            AND NOT EXISTS (
                SELECT 1 FROM tbl_customer_visits cv
                JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
                WHERE lc.customer_id = @customer_id
                AND cv.is_free = 1
                AND cv.service_id = lr.service_id
            )
        THEN 'Milestone Reached!'

        -- milestone hit and already redeemed
        WHEN (SELECT COUNT(*) FROM tbl_customer_visits cv
              JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
              WHERE lc.customer_id = @customer_id
              AND cv.is_free = 0) >= lr.visit_required
            AND EXISTS (
                SELECT 1 FROM tbl_customer_visits cv
                JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
                WHERE lc.customer_id = @customer_id
                AND cv.is_free = 1
                AND cv.service_id = lr.service_id
            )
        THEN 'Redeemed'

        -- not yet reached
        ELSE CONCAT(lr.visit_required - 
             (SELECT COUNT(*) FROM tbl_customer_visits cv
              JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
              WHERE lc.customer_id = @customer_id
              AND cv.is_free = 0), ' more visits')
    END AS CHAR) AS progress
FROM tbl_loyal_rewards lr
JOIN tbl_servicesname s ON s.serviceName_id = lr.service_id
ORDER BY lr.visit_required ASC
";
                return con.Query<LoyaltyCardModel>(sql, new { customer_id }).ToList();
            }
        }


        // STAMP VISIT
        public bool StampVisit(int card_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_customer_visits 
                        (card_id, visit_date, is_free)
                    VALUES 
                        (@card_id, NOW(), 0)";
                return con.Execute(sql, new { card_id }) > 0;
            }
        }
        // Get total visits
        public int GetTotalVisits(int card_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) 
                    FROM tbl_customer_visits 
                    WHERE card_id = @card_id 
                    AND is_free = 0";
                return con.ExecuteScalar<int>(sql, new { card_id });
            }
        }

        // Check if already stamped today
        public bool IsAlreadyStampedToday(int card_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) 
                    FROM tbl_customer_visits 
                    WHERE card_id = @card_id 
                    AND DATE(visit_date) = CURDATE()
                    AND is_free = 0";
                return con.ExecuteScalar<int>(sql, new { card_id }) > 0;
            }
        }

        // Check if total visits hit a milestone
        public LoyaltyCardModel GetMilestone(int total_visits)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT lr.visit_required, s.serviceName AS service_name
                    FROM tbl_loyal_rewards lr
                    JOIN tbl_servicesname s ON s.serviceName_id = lr.service_id
                    WHERE lr.visit_required = @total_visits";
                return con.QueryFirstOrDefault<LoyaltyCardModel>(sql, new { total_visits });
            }
        }

        // REDEEM FREE SERVICE
        public bool RedeemFreeService(int card_id, int service_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_customer_visits 
                        (card_id, service_id, visit_date, is_free)
                    VALUES 
                        (@card_id, @service_id, NOW(), 1)";
                return con.Execute(sql, new { card_id, service_id }) > 0;
            }
        }
        // REDEEMABLE SERVICE
        public List<LoyaltyCardModel> GetRedeemableService(int customer_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
    lr.service_id,
    s.serviceName AS service_name
FROM tbl_loyal_rewards lr
JOIN tbl_servicesname s ON s.serviceName_id = lr.service_id
WHERE 
    -- count ALL regular visits (no service_id filter)
    lr.visit_required <= (
        SELECT COUNT(*) FROM tbl_customer_visits cv
        JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
        WHERE lc.customer_id = @customer_id
        AND cv.is_free = 0
    )
    AND
    -- check per milestone if redeemed using FLOOR logic
    FLOOR((
        SELECT COUNT(*) FROM tbl_customer_visits cv
        JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
        WHERE lc.customer_id = @customer_id
        AND cv.is_free = 0
    ) / lr.visit_required)
    >
    (
        SELECT COUNT(*) FROM tbl_customer_visits cv
        JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
        WHERE lc.customer_id = @customer_id
        AND cv.is_free = 1
        AND cv.service_id = lr.service_id  -- ✔ filter redeemed by milestone service
    )
ORDER BY lr.visit_required ASC";
                return con.Query<LoyaltyCardModel>(sql, new { customer_id }).ToList();
            }
        }
        // IS SERVICE ALREADY REDEEMED
        public bool IsServiceAlreadyRedeemed(int customer_id, int service_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) 
                    FROM tbl_customer_visits cv
                    JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
                    WHERE lc.customer_id = @customer_id
                    AND cv.is_free = 1
                    AND cv.service_id = @service_id";

                int count = con.ExecuteScalar<int>(sql, new { customer_id, service_id });
                return count > 0;
            }
        }

        // UNREDEEM FREE SERVICE
        public bool IsAllMilestonesRedeemed(int customer_id)
        {
            using (var con = Database.GetConnection())
            {
                // Total milestones
                var totalMilestones = con.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM tbl_loyal_rewards");

                // Total redeemed
                var totalRedeemed = con.ExecuteScalar<int>(
                    @"SELECT COUNT(*) FROM tbl_customer_visits cv
              JOIN tbl_loyal_card lc ON lc.card_id = cv.card_id
              WHERE lc.customer_id = @customer_id
              AND cv.is_free = 1", new { customer_id });

                // ✔ All redeemed only if redeemed count matches total milestones
                return totalRedeemed == totalMilestones && totalMilestones > 0;
            }
        }

    }
}
