using Dapper;
using Laundry.Data;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class TransactionDetailsRepository
    {
        public void AddTransactionDetails(TransactionDetailsModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_transaction_details (transaction_id, product_id, product_size_id, qty_delivered, qty_accepted, qty_rejected, qty_remaining, total_remaining, unit_price, total)
                            VALUES (@transaction_id, @product_id, @product_size_id, @qty_delivered, @qty_accepted, @qty_rejected, @qty_remaining, @total_remaining, @unit_price, @total)";
                con.Execute(sql, model);
            }
        }

        public IEnumerable<TransactionDetailsModel> GetTransactionDetailsByProductId(int transaction_id, int product_id)
        {

            using (var con = Database.GetConnection()) 
            {
                var sql = @"
                    SELECT
                td.transaction_id,
                td.product_id,
                td.qty_delivered,
                td.qty_accepted,
                td.qty_rejected ,
                CASE 
                    WHEN td.qty_accepted = td.qty_delivered THEN 'Completed'
                    WHEN td.qty_accepted < td.qty_delivered THEN 'Partially Received'
                    ELSE 'Over-Delivered'
                END AS DetailStatus
            FROM tbl_transaction_details td
            WHERE td.product_id = @ProductId AND td.transaction_id = @Transaction_id;
                            ";
                return con.Query<TransactionDetailsModel>(sql, new { ProductId = product_id, Transaction_id = transaction_id });
            }

        }
    }
}
