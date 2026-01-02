using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class DiscountRepository
    {
        public IEnumerable<DiscountModel> getAllDiscounts()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount WHERE is_deleted = 0";
                return con.Query<DiscountModel>(sql);
            }
               
        }
        public async Task<IEnumerable<DiscountModel>> GetAllDiscountAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_discount WHERE is_deleted = 0";
                var result = await con.QueryAsync<DiscountModel>(sql);

                return result;
            }

        }
        public DiscountModel GetDiscountType(string type) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount WHERE discount_type = @type AND is_deleted = 0";
                return con.QueryFirstOrDefault<DiscountModel>(sql, new { type = type });
            }

        }
        public IEnumerable<DiscountModel> Discounts() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                          discount_id,
                          CONCAT(discount_type, ' ', promo_code) AS discount_and_promo_code,
                          discount_rate,
                          expiry_date,
                          status,
                            vat_exempt
                        FROM tbl_discount
                        WHERE 
                          status != 'Expired' 
                          ;
                        ";
                return con.Query<DiscountModel>(sql);
            }

        }
        public DiscountModel GetDiscountById(int discountId)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount WHERE discount_id = @discount_id AND is_deleted = 0";
                return con.QueryFirstOrDefault<DiscountModel>(sql, new { discount_id = discountId });
            }
                
        }
        public int AddDiscount(DiscountModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_discount 
                    (discount_type, promo_code, discount_rate, expiry_date, per_customer_limit, notif_on_create, notif_on_expired, vat_exempt)
                    VALUES 
                    (@discount_type, @promo_code, @discount_rate, @expiry_date, @per_customer_limit, @notif_on_create, @notif_on_expired, @vat_exempt);
                    SELECT LAST_INSERT_ID();";

                return con.ExecuteScalar<int>(sql, model);
            }
        }
        public void UpdateDiscount(DiscountModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_discount SET discount_type =@discount_type, promo_code =@promo_code, discount_rate=@discount_rate, expiry_date = @expiry_date, vat_exempt = @vat_exempt WHERE discount_id = @discount_id";
                con.Execute(sql, model);
            }
                
        }
        public void DeleteDiscount(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_discount SET is_deleted = 1 WHERE discount_id = @discount_id";
                con.Execute(sql, new { discount_id = id });
            }
                
        }

       public void PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_discount WHERE discount_id = @discount_id";
                con.Execute(sql, new { discount_id = id });
            }
        }
        public void RestoreDiscount(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_discount SET is_deleted = 0 WHERE discount_id = @discount_id";
                con.Execute(sql, new { discount_id = id });
            }

        }

        // DISCOUNT REPORT

        public DiscountModel TotalDiscount() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT SUM(discount_amount) AS TotalDiscount
                            FROM tbl_payment";
                return con.Query<DiscountModel>(sql).FirstOrDefault();
            }
        }
        public DiscountModel TotalDiscount(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT SUM(discount_amount) AS TotalDiscount
                            FROM tbl_payment
                            WHERE paid_at BETWEEN @start AND @end";
                return con.Query<DiscountModel>(sql, new {start = start, end = end}).FirstOrDefault();
            }
        }
        public DiscountModel TopItem() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT s.serviceName AS TopItem
                            FROM tbl_payment p
                            JOIN tbl_appointment a ON p.appointment_id = a.appointment_id
                            JOIN tbl_appointment_services a_s ON a_s.appointment_id = a.appointment_id
                            JOIN tbl_servicesname s ON s.serviceName_id = a_s.serviceName_id
                            GROUP BY s.serviceName
                            ORDER BY SUM(p.discount_amount) DESC
                            LIMIT 1;";
                return con.Query<DiscountModel>(sql).FirstOrDefault();
            }
        }
        public DiscountModel TopItem(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT s.serviceName AS TopItem
                            FROM tbl_payment p
                            JOIN tbl_appointment a ON p.appointment_id = a.appointment_id
                            JOIN tbl_appointment_services a_s ON a_s.appointment_id = a.appointment_id
                            JOIN tbl_servicesname s ON s.serviceName_id = a_s.serviceName_id
                            WHERE p.paid_at BETWEEN @start AND @end
                            GROUP BY s.serviceName
                            ORDER BY SUM(p.discount_amount) DESC
                            LIMIT 1;";
                return con.Query<DiscountModel>(sql, new { start = start, end = end}).FirstOrDefault();
            }
        }
        public DiscountModel DiscountedRate() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT AVG(discount_amount / total_amount * 100) AS AverageDiscountRate
                            FROM tbl_payment
                            ";
                return con.Query<DiscountModel>(sql).FirstOrDefault();
            }
        }
        public DiscountModel DiscountedRate(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT AVG(discount_amount / total_amount * 100) AS AverageDiscountRate
                            FROM tbl_payment
                            WHERE paid_at BETWEEN @start AND @end;";
                return con.Query<DiscountModel>(sql, new { start = start, end = end}).FirstOrDefault();
            }
        }

        // GRID DATA

        public IEnumerable<DiscountModel> AllDiscounts() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            DATE(p.paid_at) AS Date,
                            s.serviceName AS Item,
                            (p.total_amount + p.discount_amount) AS OriginalPrice,
                            p.discount_amount AS Discount,
                            p.total_amount AS FinalPrice
                        FROM tbl_payment p
                        JOIN tbl_appointment a ON p.appointment_id = a.appointment_id
                        JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                        JOIN tbl_servicesname s ON aps.serviceName_id = s.serviceName_id";
                return con.Query<DiscountModel>(sql).ToList();
            }
        }
        public IEnumerable<DiscountModel> AllDiscounts(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            DATE(p.paid_at) AS Date,
                            s.serviceName AS Item,
                            (p.total_amount + p.discount_amount) AS OriginalPrice,
                            p.discount_amount AS Discount,
                            p.total_amount AS FinalPrice
                        FROM tbl_payment p
                        JOIN tbl_appointment a ON p.appointment_id = a.appointment_id
                        JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                        JOIN tbl_servicesname s ON aps.serviceName_id = s.serviceName_id
                        WHERE p.paid_at BETWEEN @start AND @end;";
                return con.Query<DiscountModel>(sql, new { start = start, end = end}).ToList();
            }
        }

        public List<DiscountModel> GetExpiringDiscounts(DateTime threshold)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
            SELECT * FROM tbl_discount
            WHERE expiry_date IS NOT NULL
              AND expiry_date <= @threshold
              AND status != 'Expiredn'";

                return con.Query<DiscountModel>(sql, new { threshold }).ToList();
            }
        }

        public void UpdateDiscountStatus(DiscountModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_discount SET status = @status WHERE discount_id = @discount_id";
                con.Execute(sql,model);
            }
        }

        // VALIDATION   

        public bool DiscountExists(string type, string code, decimal rate, int id)
        {
            using (var con = Database.GetConnection())
            {
                string sql;

                if (type == "Promo")
                {
                    sql = @"SELECT COUNT(*) FROM tbl_discount 
                    WHERE promo_code = @code 
                        AND discount_type = @type 
                      AND discount_id != @id";
                }
                else
                {
                        sql = @"
                    SELECT COUNT(*) FROM tbl_discount 
                    WHERE discount_type = @type
                      AND discount_id != @id";
                }

                return con.ExecuteScalar<int>(sql, new { type, code, rate, id }) > 0;
            }
        }

        
    }
}
