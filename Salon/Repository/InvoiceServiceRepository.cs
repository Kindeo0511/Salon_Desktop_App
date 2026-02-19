using Dapper;
using Laundry.Data;
using Mysqlx.Crud;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class InvoiceServiceRepository: I_InvoiceServiceCart
    {

        public BindingList<ServiceCart> GetAllServicesInCartById(int invoiceId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                 SELECT
                    isc.service_cart_id,
                    isc.invoice_id AS InvoiceId,
                   isc.product_id AS ProductId,
                   p.product_name AS ItemName,
                   p.unit_type AS ProductUnitType,
                   isc.product_size_id AS ProductSizeId,
                   ps.size_label AS Size,
                   isc.service_id AS ServiceId,
                   sn.serviceName AS ItemName,
                   sb.subCategoryName AS SubCategory,
                   isc.item_type AS ItemType,
                   isc.unit_price AS Price,
                   isc.qty AS Quantity,
                   isc.duration AS Duration
                    FROM tbl_invoice_service_cart AS isc
                    LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
                    LEFT JOIN  tbl_product_size AS ps On ps.product_size_id = isc.product_size_id
                    LEFT JOIN tbl_servicesname AS sn ON isc.service_id = sn.serviceName_id
                LEFT JOIN tbl_subcategory AS sb ON sb.subCategory_id = sn.subCategory_id
                WHERE isc.invoice_id = @InvoiceId;
                ";
                var result = con.Query<ServiceCart>(sql, new { InvoiceId = invoiceId }).ToList();
                return new BindingList<ServiceCart>(result);

            }
        }
        public IEnumerable<InvoiceServicesCart> GetInvoiceForVoidAndRefund(int invoiceId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                        SELECT 
    isc.invoice_id AS InvoiceId,
    isc.product_id AS ProductId,
    p.product_name AS ItemName,
    isc.unit_price AS Price,
    isc.qty AS Quantity,
    i.discount_amount AS OverAllDiscount,
    isc.discount_amount AS ItemDiscount,
    ir.refund_qty AS RefundQty,
    i.payment_type AS PaymentMethod,
    i.reference_number AS ReferenceNumber,
    i.total_amount AS InvoiceTotal,       
    i.vat_amount AS VatAmount,          
    isc.is_voided AS Voided,
    isc.is_refunded AS Refunded,
    invTotals.InvoiceTotalBeforeDiscount
FROM tbl_invoice_service_cart AS isc
LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
LEFT JOIN tbl_invoice_refund AS ir ON ir.service_cart_id = isc.service_cart_id
LEFT JOIN tbl_invoice i ON i.invoice_id = isc.invoice_id
LEFT JOIN (
    SELECT invoice_id, SUM(unit_price * qty) AS InvoiceTotalBeforeDiscount
    FROM tbl_invoice_service_cart
    GROUP BY invoice_id
) invTotals ON invTotals.invoice_id = isc.invoice_id
WHERE isc.invoice_id = @InvoiceId;;
                ";
               return  con.Query<InvoiceServicesCart>(sql, new { InvoiceId = invoiceId }).ToList();
                

            }

        }
      
        public void AddServiceToCart(ServiceCart model)
        {
           using (var con = Database.GetConnection())
           {
                var sql = @"
                INSERT INTO tbl_invoice_service_cart (invoice_id, product_id,product_size_id, service_id,stylist_id,item_type, qty, unit_price, total_price, duration)
                VALUES (@InvoiceId, @ProductId,@ProductSizeId, @ServiceId,@StylistId, @ItemType, @Quantity, @Price, @TotalPrice, @Duration);";
                con.Execute(sql, model);
            }
        }
        public bool CheckIfServiceExistInCart(int invoice_id, int service_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) FROM tbl_invoice_service_cart
                            WHERE invoice_id = @InvoiceId AND service_id = @ServiceId AND item_type = 'Service'";
                int count = con.QuerySingle<int>(sql, new { InvoiceId = invoice_id, ServiceId = service_id });
                return count > 0;
            }
        }
        public bool CheckIfServiceExistInCart(int invoice_id, int product_id, int product_size_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) FROM tbl_invoice_service_cart
                            WHERE invoice_id = @InvoiceId AND product_id = @ProductId AND product_size_id = @product_size_id";
                int count = con.QuerySingle<int>(sql, new { InvoiceId = invoice_id, ProductId = product_id, product_size_id = product_size_id });
                return count > 0;
            }
        }
        public bool UpdateServiceQtyInCart(int invoice_id, int product_id, int product_size_id, int newQty) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_invoice_service_cart
                            SET qty = qty + @NewQty
                            WHERE invoice_id = @InvoiceId AND product_id = @ProductId AND product_size_id = @ProductSizeId";
                int rowsAffected = con.Execute(sql, new { NewQty = newQty, InvoiceId = invoice_id, ProductId = product_id, ProductSizeId = product_size_id });
                return rowsAffected > 0;
            }
        }
        public void UpdateServicesInvoice(ServiceCart model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_invoice_service_cart 
                            SET discount_amount = @DiscountAmount
                            WHERE service_cart_id = @service_cart_id";
                con.Execute(sql, model);
            }
        }
        public void UpdateServiceToCart(int id, string status) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_invoice_service_cart isc
                            LEFT JOIN tbl_invoice i ON i.invoice_id = isc.invoice_id
                            SET isc.is_voided = 1, i.status = @Status WHERE isc.service_cart_id = @Id";
                con.Execute(sql, new { Id = id, Status = status });
            }
        }
        public bool DeleteInvoiceById(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_invoice_service_cart WHERE service_cart_id = @id";
                int rowsAffected = con.Execute(sql, new { id = id });
                return rowsAffected > 0;
            }
        }
        public int GetServiceInvoiceId(int invoice_id, int service_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT service_cart_id FROM tbl_invoice_service_cart
                            WHERE invoice_id = @InvoiceId AND service_id = @ServiceId AND item_type = 'Service'";
                return con.QuerySingleOrDefault<int>(sql, new { InvoiceId = invoice_id, ServiceId = service_id });
            }
        }
        public void RefundServiceToCart(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_invoice_service_cart isc
                            LEFT JOIN tbl_invoice i ON i.invoice_id = isc.invoice_id
                            SET isc.is_refunded = 1 WHERE isc.service_cart_id = @Id";
                con.Execute(sql, new { Id = id });
            }
        }
        public bool RemoveServiceFromCart(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                DELETE FROM tbl_invoice_service_cart WHERE service_cart_id = @Id;";
                int rowsAffected =  con.Execute(sql, new { Id = id });

                return rowsAffected > 0;
            }
        }
        public void RemoveProductFromCart(int Id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"DELETE FROM tbl_invoice_service_cart WHERE service_cart_id = @Id";
                con.Execute(sql, new { Id });
            }
        }

        public ServiceCart GetInvoiceCartId(int id, int product_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT service_cart_id
                            FROM `tbl_invoice_service_cart`
                            WHERE item_type ='Product' AND invoice_id =@Id AND product_id = @ProductId";

                return con.QuerySingleOrDefault<ServiceCart>(sql, new { Id = id, ProductId = product_id });
            }
        }

    }
}
