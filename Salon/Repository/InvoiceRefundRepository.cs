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
    public class InvoiceRefundRepository
    {

        public void AddRefund(InvoiceRefundModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_invoice_refund
                            (service_cart_id, refund_qty, reason, refunded_by, refunded_at)
                            VALUES (@service_cart_id, @refund_qty, @reason, @refunded_by, @refunded_at)";

                con.Execute(sql, model);
            }
        }
        public int CheckRefundQty(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT SUM(refund_qty) 
                    FROM tbl_invoice_refund
                    WHERE service_cart_id = @Id";

   
                int refundQty = con.ExecuteScalar<int>(sql, new { Id = id });

                return refundQty;
            }
        }

        public void UpdateRefundStatus() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_invoice i
                        JOIN (
                            SELECT isc.invoice_id
                            FROM tbl_invoice_service_cart isc
                            LEFT JOIN tbl_invoice_refund ir ON ir.service_cart_id = isc.service_cart_id
                            GROUP BY isc.service_cart_id, isc.invoice_id, isc.qty
                            HAVING SUM(ir.refund_qty) = isc.qty
                        ) fully_refunded
                        ON i.invoice_id = fully_refunded.invoice_id
                        SET i.status = 'Refunded';
                        ";
                con.Execute(sql);
            }
        }
    }
}
