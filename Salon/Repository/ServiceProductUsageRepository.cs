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
    public class ServiceProductUsageRepository : IServiceProductUsage
    {
        public int GetProductUsageCount(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) 
                        FROM tbl_service_product 
                        WHERE service_id = @id AND is_deleted = 0;";
                return con.ExecuteScalar<int>(sql, new { id });
            }
        }
        public IEnumerable<ServiceProductUsageModel> GetAllServiceProducts(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName, p.product_id, p.product_name,p.brand,p.unit_type, sp.qty_required
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                        WHERE s.serviceName_id = @id AND sp.is_deleted = 0;";
                return con.Query<ServiceProductUsageModel>(sql, new { id }).ToList();
            }
               
        }
        public IEnumerable<ServiceProductUsageModel> GetAllServiceProductsAsync(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName, p.product_id, p.product_name,p.brand, sp.qty_required
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                        WHERE s.serviceName_id = @id AND sp.is_deleted = 0;";
                return con.Query<ServiceProductUsageModel>(sql, new { id });

              
            }
        }
        public IEnumerable<ServiceProductUsageModel> GetTotalProductCost()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName,s.duration
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                       GROUP BY s.serviceName_id;";
                return con.Query<ServiceProductUsageModel>(sql).ToList();
            }
        }
        public int AddServiceProduct(ServiceProductUsageModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_service_product (service_id, product_id, qty_required)
                        VALUES (@service_id, @product_id, @total_usage_amount)";
                return con.Execute(sql, model);
            }
                
        }

        public int UpdateServiceProduct(ServiceProductUsageModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_service_product 
                    SET product_id = @product_id,
                        qty_required = @total_usage_amount
             
                        WHERE service_id = @service_id";
                return con.Execute(sql, model);
            }
               
        }
        public int DeleteServiceProduct(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_service_product SET is_deleted = 1 WHERE service_product_id = @service_product_id";
               return con.Execute(sql, new { service_product_id = id });
            }
              
        }
        public int PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_service_product WHERE service_product_id = @service_product_id";
               return con.Execute(sql, new { service_product_id = id });
            }
        }
        public int RestoreServiceProduct(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_service_product SET is_deleted = 0 WHERE service_product_id = @service_product_id";
                return con.Execute(sql, new { service_product_id = id });
            }
        }

        public bool ProductUsageExists(int product_id, int service_id, int excludeId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) 
            FROM tbl_service_product 
            WHERE product_id = @product_id 
              AND service_id = @service_id 
              AND is_deleted = 0 
              AND service_product_id != @excludeId";


                return con.ExecuteScalar<int>(sql, new { product_id, service_id, excludeId }) > 0;
            }
        }

        public ServiceProductUsageModel GetServiceUsage(int service_id, int product_id, string brand, int qty)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_service_product 
                            WHERE service_id = @service_id AND product_id = @product_id AND qty_required = @qty AND is_deleted = 0";
                return con.QueryFirstOrDefault<ServiceProductUsageModel>(sql, new { service_id, product_id, brand, qty });
            }
        }

        public bool IsServiceProductUsed(int product_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_inventory WHERE product_id = @product_id)   
                                    OR EXISTS (SELECT 1 FROM tbl_delivery_items WHERE product_id = @product_id)
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql, new { product_id }) == 1;
            }
        }
    }
}
