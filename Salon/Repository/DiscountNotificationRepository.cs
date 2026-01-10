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
                var sql = "SELECT * FROM tbl_discount_notification";
                return con.Query<DiscountNotificationModel>(sql).ToList();
            }
        }
        public void addNotification(DiscountNotificationModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_discount_notification
        (customer_email, customer_name, subject, body, is_sent, created_at, sent_at)
        VALUES (@customer_email, @customer_name, @subject, @body, @is_sent, @created_at, @sent_at)";
                con.Execute(sql, model);
            }
        }
       
        public void UpdateNotificationStatus(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_discount_notification SET is_sent = 1, sent_at = NOW() WHERE notif_id = @id";
                con.Execute(sql, new { id = id});
            }
        }
    }
}
