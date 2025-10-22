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
    public class DeliveryRepository : IDelivery
    {
        public IEnumerable<DeliveryModel> GetAllDelivery()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT d.delivery_id, s.supplier_id, s.supplier_name, d.date, d.invoice, d.received_by FROM tbl_delivery as d 
                        LEFT JOIN tbl_supplier as s ON s.supplier_id = d.supplier_id;";

                return con.Query<DeliveryModel>(sql);
            }

        }
        public int AddDelivery(DeliveryModel deliveryModel)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_delivery (supplier_id, date, invoice, received_by) VALUES (@supplier_id, @date, @invoice, @received_by); SELECT LAST_INSERT_ID();";

                return con.QuerySingle<int>(sql, deliveryModel);
            }
               
        }
        public bool DeliveryExists(string invoice) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM `tbl_delivery` WHERE invoice = @invoice;";
                return con.ExecuteScalar<int>(sql, new { invoice = invoice}) > 0;
            }
        }
        // DELIVERY REPORT

        public DeliveryModel TotalDelivery() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) AS TotalDelivery
                            FROM tbl_delivery 
                            WHERE MONTH(date) = MONTH(CURRENT_DATE) AND YEAR(date) = YEAR(CURRENT_DATE);";
                return con.Query<DeliveryModel>(sql).FirstOrDefault();
            }
        }

        public DeliveryModel TotalDelivery(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS TotalDelivery
                            FROM tbl_delivery 
                            WHERE date BETWEEN @start AND @end";
                return con.Query<DeliveryModel>(sql, new { start = start, end = end}).FirstOrDefault();
            }
        }
    }
}
