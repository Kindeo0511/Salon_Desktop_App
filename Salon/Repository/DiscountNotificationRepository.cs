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
    public class DiscountNotificationRepository
    {
        public IEnumerable<DiscountNotificationModel> All() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount_notification WHERE status = 'Pending'";
                return con.Query<DiscountNotificationModel>(sql).ToList();
            }
        }
        public void addNotification(DiscountNotificationModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_discount_notification (discount_id, customer_id, status) VALUES (@discount_id, @customer_id, @status)";
                con.Execute(sql, model);
            }
        }
       
        public void UpdateNotificationStatus(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_discount_notification SET status = 'Sent' WHERE notif_id = @id";
                con.Execute(sql, new { id = id});
            }
        }
    }
}
