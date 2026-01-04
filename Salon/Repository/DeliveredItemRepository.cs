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
    public class DeliveredItemRepository : IDeliveredItems
    {
        public IEnumerable<DeliveryItemModel> GetDeliveryItems(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT d_i.delivery_item_id, d_i.delivery_id,d.invoice,s.supplier_name, p.product_id, p.product_name, d_i.qty_delivered, d_i.unit_price, d_i.total_price, d_i.expiry_date, d_i.notes
                FROM tbl_delivery_items as d_i 
                LEFT JOIN tbl_delivery AS d ON d.delivery_id = d_i.delivery_id
                LEFT JOIN tbl_supplier AS s ON s.supplier_id = d.supplier_id
                LEFT JOIN tbl_products as p ON p.product_id = d_i.product_id
                WHERE d.delivery_id = @delivery_id";

                return con.Query<DeliveryItemModel>(sql, new { delivery_id = id }).ToList();
            }
          
        }
        public IEnumerable<DeliveryItemModel> GetDeliveryItemsByInvoiceNumber(string invoice) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
    d.invoice,
    s.supplier_name,
    di.delivery_id,
    di.delivery_item_id,
    di.product_id,
    p.product_name,
    di.product_size_id,
    ps.size_label,
    di.qty_delivered,
    di.content,
    COALESCE(SUM(td.qty_accepted),0) AS total_accepted,
    COALESCE(SUM(td.qty_rejected),0) AS total_rejected,
    di.unit_price,
    di.total_price,
    CASE 
        WHEN COALESCE(SUM(td.qty_accepted),0) = di.qty_delivered THEN 'Completed'
        ELSE 'Partially Received'
    END AS item_status
FROM tbl_delivery_items di
JOIN tbl_delivery d 
       ON di.delivery_id = d.delivery_id
LEFT JOIN tbl_supplier s
       ON s.supplier_id = d.supplier_id
LEFT JOIN tbl_products p
       ON p.product_id = di.product_id
LEFT JOIN tbl_product_size ps
       ON ps.product_size_id = di.product_size_id
LEFT JOIN tbl_stock_transaction t 
       ON t.reference_no = d.invoice
LEFT JOIN tbl_transaction_details td 
       ON td.transaction_id = t.transaction_id 
      AND td.product_id = di.product_id
      AND td.product_size_id = di.product_size_id   -- ✅ scope accepted/rejected to the right size
WHERE d.invoice = @invoice_id 
  AND d.status != 'Completed'
GROUP BY 
    d.invoice,
    s.supplier_name,
    di.delivery_id,
    di.delivery_item_id,
    di.product_id,
    p.product_name,
    di.product_size_id,
    ps.size_label,
    di.qty_delivered,
    di.content,
    di.unit_price,
    di.total_price;



";

                return con.Query<DeliveryItemModel>(sql, new { invoice_id = invoice }).ToList();
            }
        }
        public void AddDeliveryItem(DeliveryItemModel item)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_delivery_items (delivery_id, product_id,product_size_id, qty_delivered, content, total_qty, unit_price, total_price, expiry_date, notes) VALUES (@delivery_id, @product_id,@product_size_id, @qty_delivered, @content, @total_qty, @unit_price, @total_price, @expiry_date, @notes);";
                 con.Execute(sql, item);
            }
               
        }


        // DELIVERY REPORT

        public DeliveryItemModel TotalQty() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT SUM(qty_delivered) AS TotalQty 
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
                var sql = @"SELECT SUM(qty_delivered) AS TotalQty 
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
                            di.qty_delivered AS Quantity,
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
                            di.qty_delivered AS Quantity,
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
