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
                    (appointment_id,invoice_number, customer_id, total_amount, vat_amount, discount_amount, created_at)
                VALUES 
                    (@AppointmentID, @InvoiceNumber, @CustomerID, @TotalAmount, @VATAmount, @DiscountAmount, CURRENT_TIMESTAMP());
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
                    (invoice_number, total_amount, vat_amount, discount_amount,notes,payment_method_id, reference_number, status, created_at)
                VALUES 
                    (@InvoiceNumber, @TotalAmount, @VATAmount, @DiscountAmount,@Notes,@payment_method_id,@reference_number, @status, CURRENT_TIMESTAMP());
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
                                payment_method_id = @payment_method_id,
                                reference_number = @reference_number,    
                                status = @status,
                                created_at = CURRENT_TIMESTAMP()
                              WHERE invoice_id = @InvoiceID";
                con.Execute(sql, model);
            }
        }

        public IEnumerable<InvoiceModel> GetInvoice(int page_size, int off_set) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT isc.invoice_id AS InvoiceID,
  		                    i.invoice_number AS InvoiceNumber,
		                    i.total_amount AS TotalAmount,		
                            i.payment_method_id,
                            pm.name AS PaymentMethod,
                            i.reference_number,
                            i.status,
                            i.created_at AS Timestamp
                    FROM tbl_invoice  AS i
                    LEFT JOIN tbl_appointment AS a ON a.appointment_id = i.appointment_id
                    LEFT JOIN tbl_invoice_service_cart AS isc ON isc.invoice_id = i.invoice_id
                    LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
                    LEFT JOIN tbl_servicesname AS sn ON isc.service_id = sn.serviceName_id
                    LEFT JOIN tbl_payment_method AS pm ON pm.id = i.payment_method_id    
                    GROUP BY isc.invoice_id
                    LIMIT @page_size OFFSET @off_set";

                return con.Query<InvoiceModel>(sql, new { page_size, off_set}).ToList();
            }
        }
        public IEnumerable<InvoiceModel> GetInvoice(DateTime start_date, DateTime end_date, int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT isc.invoice_id AS InvoiceID,
  		                    i.invoice_number AS InvoiceNumber,
		                    i.total_amount AS TotalAmount,		
                            i.payment_method_id,
                            pm.name AS PaymentMethod,
                            i.reference_number,
                            i.status,
                            i.created_at AS Timestamp
                    FROM tbl_invoice  AS i
                    LEFT JOIN tbl_appointment AS a ON a.appointment_id = i.appointment_id
                    LEFT JOIN tbl_invoice_service_cart AS isc ON isc.invoice_id = i.invoice_id
                    LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
                    LEFT JOIN tbl_servicesname AS sn ON isc.service_id = sn.serviceName_id
                    LEFT JOIN tbl_payment_method AS pm ON pm.id = i.payment_method_id  
                    WHERE i.created_at BETWEEN @start_date AND @end_date
                    GROUP BY isc.invoice_id
                    LIMIT @page_size OFFSET @off_set";

                return con.Query<InvoiceModel>(sql, new { start_date, end_date, page_size, off_set}).ToList();
            }
        }

        public int TotalTransactionList() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_transaction";

                return con.ExecuteScalar<int>(sql);
            }
        }
        // SALES REPORT
        public int CountTotalInvoice() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM sales_report_summary_view";

                return con.ExecuteScalar<int>(sql);
            }
        }
        public InvoiceModel SalesReportSummary() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM sales_report_summary_view";

                return con.QueryFirstOrDefault<InvoiceModel>(sql);
            }
        }
        public IEnumerable<InvoiceServicesCart> SalesReportView(int page_size, int off_set) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM salesreportview LIMIT @page_size OFFSET @off_set";

                return con.Query<InvoiceServicesCart>(sql, new { page_size, off_set });
            }
        }
        public IEnumerable<InvoiceServicesCart> SalesReportView(DateTime start, DateTime end, int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM salesreportview WHERE timestamp BETWEEN @start AND @end LIMIT @page_size OFFSET @off_set";

                return con.Query<InvoiceServicesCart>(sql, new { start, end, page_size, off_set});
            }
        }
        public InvoiceModel TotalServiceSaleView() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM total_service_sale_view LIMIT @page_size OFFSET @off_set";

                return con.QueryFirstOrDefault<InvoiceModel>(sql);
            }
        }

        public InvoiceModel TotalProductSaleView()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM total_product_sale_view";

                return con.QueryFirstOrDefault<InvoiceModel>(sql);
            }
        }
    }
}
