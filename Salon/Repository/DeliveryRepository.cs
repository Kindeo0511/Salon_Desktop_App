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
        public IEnumerable<DeliveryItemModel> GetDeliveryInvoice()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT DISTINCT d.delivery_id, d.invoice, s.supplier_id, s.supplier_name, d.status
                            FROM tbl_delivery AS d
                            LEFT JOIN tbl_supplier AS s ON s.supplier_id = d.supplier_id
                            WHERE d.status != 'Completed';
                            ";
                return con.Query<DeliveryItemModel>(sql);
            }
        }
        public async Task<IEnumerable<DeliveryModel>> GetAllDeliveryAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT d.delivery_id, s.supplier_id, s.supplier_name, d.date, d.invoice, d.received_by FROM tbl_delivery as d 
                        LEFT JOIN tbl_supplier as s ON s.supplier_id = d.supplier_id;";

                var result = await  con.QueryAsync<DeliveryModel>(sql);

                return result;
            }
        }
        public int AddDelivery(DeliveryModel deliveryModel)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_delivery (supplier_id, date, invoice, received_by, status) VALUES (@supplier_id, @date, @invoice, @received_by, @status); SELECT LAST_INSERT_ID();";

                return con.QuerySingle<int>(sql, deliveryModel);
            }
               
        }
        public void UpdateDeliveryStatus() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_delivery
                        SET status = 'Completed'
                        WHERE delivery_id IN (
                          SELECT delivery_id FROM (
                            SELECT delivery_id
                            FROM (
                              SELECT di.delivery_id,
                                     di.product_id,
                                     di.qty_delivered,
                                     SUM(td.qty_accepted) AS total_accepted
                              FROM tbl_delivery_items di
                              JOIN tbl_delivery d ON di.delivery_id = d.delivery_id
                              LEFT JOIN tbl_stock_transaction t ON t.reference_no = d.invoice
                              LEFT JOIN tbl_transaction_details td 
                                     ON td.transaction_id = t.transaction_id 
                                    AND td.product_id = di.product_id
                              GROUP BY di.delivery_id, di.product_id, di.qty_delivered
                            ) per_item
                            GROUP BY delivery_id
                            HAVING SUM(CASE WHEN total_accepted = qty_delivered THEN 1 ELSE 0 END) = COUNT(*)
                          ) AS sub
                        );
                        ";
                con.Execute(sql);
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
