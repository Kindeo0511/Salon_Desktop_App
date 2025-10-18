using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class DiscountUsageRepository :IDiscountUsage
    {
        public int UsageCount(int discount_id, int customer_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_discount_usage WHERE discount_id = @discount_id AND customer_id = @customer_id";
                return con.ExecuteScalar<int>(sql, new { discount_id, customer_id });
            }

        }
            
        
        public void AddUsage(DiscountUsageModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_discount_usage (discount_id, customer_id, appointment_id, used_on) VALUES (@discount_id, @customer_id, @appointment_id, @used_on)";
                con.Execute(sql, model);
            }
        }
    }
}
