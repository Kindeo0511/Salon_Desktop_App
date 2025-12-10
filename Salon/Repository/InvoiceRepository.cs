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
    public class InvoiceRepository : I_Invoice
    {
        public int GetInvoiceById(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT invoice_id FROM tbl_invoice WHERE appointment_id = @id";
                return con.QuerySingleOrDefault<int>(sql, new { id = id } );

            }
        }
        public int CreateInvoice(InvoiceModel model)
        {


            using (var con = Database.GetConnection())
            {
                var sql = @"
                INSERT INTO tbl_invoice 
                    (appointment_id, customer_id, total_amount, vat_amount, discount_amount, payment_method, timestamp)
                VALUES 
                    (@AppointmentID, @CustomerID, @TotalAmount, @VATAmount, @DiscountAmount, @PaymentMethod, @Timestamp);
                SELECT LAST_INSERT_ID();
            ";

        
        int newId = con.QuerySingle<int>(sql, model);
                return newId;

            }

        }
        public void UpdateInvoice(InvoiceModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_invoice
                            SET total_amount = @TotalAmount,
                                vat_amount = @VatAmount,
                                discount_amount = @DiscountAmount,
                                payment_method = @PaymentMethod,
                                timestamp = @TimeStamp
                              WHERE invoice_id = @InvoiceID";
                con.Execute(sql, model);
            }
        }
    }
}
