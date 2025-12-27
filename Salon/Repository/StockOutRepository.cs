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
    public class StockOutRepository
    {

        public IEnumerable<StockOutModel> GetAllTransactionDetails() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT p.product_name, ps.size_label, td.qty_delivered, td.qty_accepted, td.qty_rejected, td.qty_remaining, td.total_remaining,  td.unit_price, td.total, d_i.expiry_date

                        FROM tbl_transaction_details td
                        LEFT JOIN tbl_products p ON p.product_id = td.product_id
                        LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                        LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                        LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                        LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id";

                return con.Query<StockOutModel>(sql);
            }
        }
        public StockOutModel GetTransactionId(int product_id) 
        {
            using (var con =  Database.GetConnection()) 
            {
                var sql = @"SELECT td.transaction_id, ps.product_size_id
                        FROM tbl_transaction_details td
                        LEFT JOIN tbl_products p ON p.product_id = td.product_id
                        LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                        LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                        LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                        LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                        WHERE p.product_id = @ProductId AND td.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                        LIMIT 1;";

                return con.QueryFirstOrDefault<StockOutModel>(sql, new { ProductId = product_id });
            }
        }

        public void UpdateTransaction(int transaction_id, int deduct) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_transaction_details td
                            LEFT JOIN tbl_products p ON p.product_id = td.product_id
                            LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                            LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                            LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                            SET td.total_remaining = GREATEST(td.total_remaining - @qty_deduct,0),
                                td.qty_remaining = GREATEST((td.total_remaining - @qty_deduct) / ps.content,0)
                            WHERE td.transaction_id = @Id  AND td.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                            LIMIT 1;
                            ";
                con.Execute(sql, new { Id = transaction_id, qty_deduct = deduct });
            }
        }

        public void UpdateProducTransaction(int transaction_id, int product_size, int qty) 
        {
            using (var con  = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_transaction_details td
JOIN tbl_products p 
       ON p.product_id = td.product_id
JOIN tbl_product_size ps 
       ON ps.product_size_id = td.product_size_id
JOIN tbl_stock_transaction t 
       ON t.transaction_id = td.transaction_id
JOIN tbl_delivery d 
       ON d.invoice = t.reference_no
SET td.total_remaining = GREATEST(td.total_remaining - (ps.content * @Qty), 0),
    td.qty_remaining   = GREATEST(td.qty_remaining - @Qty, 0)
WHERE td.transaction_id = @TransactionId
  AND td.product_size_id = @Size
  AND td.total_remaining > 0
LIMIT 1;
";

                con.Execute(sql, new { TransactionId = transaction_id, Size = product_size, Qty=@qty });
            }
        }
        public void VoidProductTransaction(int transaction_id, int product_size, int qty)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_transaction_details td
                    LEFT JOIN tbl_products p ON p.product_id = td.product_id
                    LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                    LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                    LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                    LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                    SET td.total_remaining = GREATEST(td.total_remaining + (ps.content * @Qty),0),
                        td.qty_remaining = GREATEST(td.qty_remaining + @Qty, 0)
                    WHERE td.transaction_id = @TransactionId  AND ps.product_size_id =@Size AND td.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                    LIMIT 1;";

                con.Execute(sql, new { TransactionId = transaction_id, Size = product_size, Qty = @qty });
            }
        }

        public void DeductStock(int product_id, int qty_deduction) 
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute("CALL DeductConsumable(@in_product_id, @in_deduction_ml)",
                      new { in_product_id = product_id, in_deduction_ml = qty_deduction });
            }   
        }
    }
}
