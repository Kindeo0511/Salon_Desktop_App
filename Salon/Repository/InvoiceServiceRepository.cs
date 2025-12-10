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
                  SELECT sn.serviceName_id AS ItemId,sc.invoice_id AS InvoiceId, sn.serviceName AS ItemName, sc.unit_price AS Price, sc.qty AS Quantity, sc.duration AS Duration FROM tbl_invoice_service_cart AS sc
                 LEFT JOIN tbl_servicesname AS sn ON sn.serviceName_id = sc.serviceName_id
                 WHERE invoice_id = @InvoiceId;";
                var result = con.Query<ServiceCart>(sql, new { InvoiceId = invoiceId }).ToList();
                return new BindingList<ServiceCart>(result);

            }
        }
      
        public void AddServiceToCart(ServiceCart model)
        {
           using (var con = Database.GetConnection())
           {
                var sql = @"
                INSERT INTO tbl_invoice_service_cart (invoice_id, serviceName_id, qty, unit_price, total_price, duration)
                VALUES (@InvoiceId, @ItemId, @Quantity, @Price, @TotalPrice, @Duration);";
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
