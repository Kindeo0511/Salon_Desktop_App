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


        // DELIVERY REPORT

        public DeliveryItemModel TotalQty() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT SUM(qty) AS TotalQty 
                            FROM tbl_delivery_items di
                            JOIN tbl_delivery d ON di.delivery_id = d.delivery_id
                            WHERE MONTH(d.date) = MONTH(CURRENT_DATE) AND YEAR(d.date) = YEAR(CURRENT_DATE);";
                return con.Query<DeliveryItemModel>(sql).FirstOrDefault();
            }
        }
        public DeliveryItemModel TotalQty(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT SUM(qty) AS TotalQty 
                            FROM tbl_delivery_items di
                            JOIN tbl_delivery d ON di.delivery_id = d.delivery_id
                            WHERE d.date BETWEEN @start AND @end;";
                return con.Query<DeliveryItemModel>(sql, new { start = start, end= end}).FirstOrDefault();
            }
        }
        public DeliveryItemModel ExpiredQty() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS ExpiredQty
                            FROM tbl_delivery_items 
                            WHERE expiry_date < CURRENT_DATE;";
                return con.Query<DeliveryItemModel>(sql).FirstOrDefault();
            }
        }

        public DeliveryItemModel ExpiredQty(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS ExpiredQty
                            FROM tbl_delivery_items 
                            WHERE expiry_date < CURRENT_DATE
                            AND delivery_id IN (
                                SELECT delivery_id FROM tbl_delivery WHERE date BETWEEN @start AND @end
                            );";
                return con.Query<DeliveryItemModel>(sql, new { start = start , end = end}).FirstOrDefault();
            }
        }

        public IEnumerable<DeliveryItemModel> DeliveryItemList()   
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            d.date AS DeliveryDate,
                            p.product_name AS ProductName,
                            di.qty AS Quantity,
                            di.unit_price AS Price,
                            di.expiry_date AS Expiry,
                            di.notes AS ItemNotes
                        FROM tbl_delivery_items di
                        JOIN tbl_delivery d ON di.delivery_id = d.delivery_id
                        JOIN tbl_products p ON di.product_id = p.product_id";
                return con.Query<DeliveryItemModel>(sql).ToList();
            }
        }
        public IEnumerable<DeliveryItemModel> DeliveryItemList(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            d.date AS DeliveryDate,
                            p.product_name AS ProductName,
                            di.qty AS Quantity,
                            di.unit_price AS Price,
                            di.expiry_date AS Expiry,
                            di.notes AS ItemNotes
                        FROM tbl_delivery_items di
                        JOIN tbl_delivery d ON di.delivery_id = d.delivery_id
                        JOIN tbl_products p ON di.product_id = p.product_id
                        WHERE d.date BETWEEN @start AND @end;";

                return con.Query<DeliveryItemModel>(sql, new { start = start, end = end}).ToList();
            }
        }
    }
}
