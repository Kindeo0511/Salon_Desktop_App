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
    public class DeliveredItemRepository : IDeliveredItems
    {
        public IEnumerable<DeliveryItemModel> GetDeliveryItems(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT d_i.delivery_item_id, d_i.delivery_id, p.product_id, p.product_name, d_i.qty, d_i.unit_price, d_i.total_price, d_i.expiry_date, d_i.notes FROM tbl_delivery_items as d_i 
                    LEFT JOIN tbl_products as p ON p.product_id = d_i.product_id
                    WHERE d_i.delivery_id = @delivery_id ";

                return con.Query<DeliveryItemModel>(sql, new { delivery_id = id }).ToList();
            }
          
        }
        public int AddDeliveryItem(DeliveryItemModel item)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_delivery_items (delivery_id, product_id, qty, unit_price, total_price, expiry_date, notes) VALUES (@delivery_id, @product_id, @qty, @unit_price, @total_price, @expiry_date, @notes); SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, item);
            }
               
        }
    }
}
