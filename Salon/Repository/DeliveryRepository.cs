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
    }
}
