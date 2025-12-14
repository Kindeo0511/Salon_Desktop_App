using Dapper;
using Laundry.Data;
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
        // Implementation of InvoiceServiceRepository methods would go here
        public BindingList<ServiceCart> GetAllServicesInCartById(int invoiceId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                  SELECT isc.invoice_id AS InvoiceId,
                       isc.product_id AS ProductId,
                       p.product_name AS ItemName,
                       isc.service_id AS ServiceId,
                       sn.serviceName AS ItemName,
                       isc.unit_price AS Price,
                       isc.qty AS Quantity,
                       isc.duration AS Duration
                FROM tbl_invoice_service_cart AS isc
                LEFT JOIN tbl_products AS p ON isc.product_id = p.product_id
                LEFT JOIN tbl_servicesname AS sn ON isc.service_id = sn.serviceName_id
                WHERE isc.invoice_id = @InvoiceId;
                ";
                var result = con.Query<ServiceCart>(sql, new { InvoiceId = invoiceId }).ToList();
                return new BindingList<ServiceCart>(result);

            }
        }
      
        public void AddServiceToCart(ServiceCart model)
        {
           using (var con = Database.GetConnection())
           {
                var sql = @"
                INSERT INTO tbl_invoice_service_cart (invoice_id, product_id, service_id, qty, unit_price, total_price, duration)
                VALUES (@InvoiceId, @ProductId, @ServiceId, @Quantity, @Price, @TotalPrice, @Duration);";
                con.Execute(sql, model);
            }
        }

    
        public bool RemoveServiceFromCart(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                DELETE FROM tbl_invoice_service_cart WHERE invoice_id = @Id;";
                int rowsAffected =  con.Execute(sql, new { Id = id });

                return rowsAffected > 0;
            }
        }

    }
}
