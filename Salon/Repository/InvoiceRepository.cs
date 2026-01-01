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
        public int GetInvoiceByNumber(string id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT invoice_id FROM tbl_invoice WHERE invoice_number = @id";
                return con.QuerySingleOrDefault<int>(sql, new { id = id });

            }
        }
        public int CreateInvoice(InvoiceModel model)
        {


            using (var con = Database.GetConnection())
            {
                var sql = @"
                INSERT INTO tbl_invoice 
                    (appointment_id,invoice_number, customer_id, total_amount, vat_amount, discount_amount, payment_method, timestamp)
                VALUES 
                    (@AppointmentID, @InvoiceNumber, @CustomerID, @TotalAmount, @VATAmount, @DiscountAmount, @PaymentMethod, @Timestamp);
                SELECT LAST_INSERT_ID();
            ";

        
        int newId = con.QuerySingle<int>(sql, model);
                return newId;

            }

        }
        public int  CreateProductInvoice(InvoiceModel model)
        {


            using (var con = Database.GetConnection())
            {
                var sql = @"
                INSERT INTO tbl_invoice 
                    (invoice_number, total_amount, vat_amount, discount_amount, payment_method, timestamp)
                VALUES 
                    (@InvoiceNumber, @TotalAmount, @VATAmount, @DiscountAmount, @PaymentMethod, @Timestamp);
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
                                notes = @Notes, 
                                payment_method = @PaymentMethod,
                                timestamp = @TimeStamp
                              WHERE invoice_id = @InvoiceID";
                con.Execute(sql, model);
            }
        }

        public IEnumerable<InvoiceModel> GetInvoice() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT isc.invoice_id AS InvoiceID,
  		                    i.invoice_number AS InvoiceNumber,
  		                    CONCAT(ca.firstName, ' ', ca.lastName) AS Name,
		                    i.total_amount AS TotalAmount,
                            i.payment_method AS PaymentMethod,		
                            i.status,
                            i.timestamp AS Timestamp
                    FROM tbl_invoice  AS i
                    LEFT JOIN tbl_appointment AS a ON a.appointment_id = i.appointment_id
                    LEFT JOIN tbl_customer_account AS ca ON ca.customer_id = a.customer_id
                    LEFT JOIN tbl_invoice_service_cart AS isc ON isc.invoice_id = i.invoice_id
                    LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
                    LEFT JOIN tbl_servicesname AS sn ON isc.service_id = sn.serviceName_id
                    WHERE  i.payment_method != 'Unpaid'
                    GROUP BY isc.invoice_id";

                return con.Query<InvoiceModel>(sql).ToList();
            }
        }
    }
}
