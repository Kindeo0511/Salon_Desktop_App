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
        public IEnumerable<ServiceProductUsageModel> GetAllServiceProducts(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName, p.product_id, p.product_name,p.brand, p.usage_type, sp.usage_amount, sp.unit_per_volume, sp.total_usage_amount, sp.total_cost
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                        WHERE s.serviceName_id = @id AND sp.is_deleted = 0;";
                return con.Query<ServiceProductUsageModel>(sql, new { id }).ToList();
            }
               
        }
        public async Task<IEnumerable<ServiceProductUsageModel>> GetAllServiceProductsAsync(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName, p.product_id, p.product_name,p.brand, p.usage_type, sp.usage_amount, sp.unit_per_volume, sp.total_usage_amount, sp.total_cost
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                        WHERE s.serviceName_id = @id AND sp.is_deleted = 0;";
                var result = await con.QueryAsync<ServiceProductUsageModel>(sql, new { id });

                return result.ToList();
            }
        }
        public IEnumerable<ServiceProductUsageModel> GetTotalProductCost()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sp.service_product_id, s.serviceName_id as service_id, s.serviceName,s.duration, SUM(sp.total_cost) as total_cost
                        FROM  tbl_service_product as sp 
                        LEFT JOIN tbl_servicesname as s ON s.serviceName_id = sp.service_id
                        LEFT JOIN tbl_products as p ON p.product_id = sp.product_id
                       GROUP BY s.serviceName_id;";
                return con.Query<ServiceProductUsageModel>(sql).ToList();
            }
        }
        public void AddServiceProduct(ServiceProductUsageModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_service_product (service_id, product_id, usage_amount, unit_per_volume, total_usage_amount, total_cost)
                        VALUES (@service_id, @product_id, @usage_amount, @unit_per_volume, @total_usage_amount, @total_cost)";
                con.Execute(sql, model);
            }
                
        }

        public void UpdateServiceProduct(ServiceProductUsageModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_service_product 
                    SET product_id = @product_id,
                        usage_amount = @usage_amount,
                        unit_per_volume = @unit_per_volume,
                        total_usage_amount = @total_usage_amount,
                        total_cost = @total_cost
                        WHERE service_product_id = @service_product_id";
                con.Execute(sql, model);
            }
               
        }
        public void DeleteServiceProduct(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_service_product SET is_deleted = 1 WHERE service_product_id = @service_product_id";
                con.Execute(sql, new { service_product_id = id });
            }
              
        }
        public void RestoreServiceProduct(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_service_product SET is_deleted = 0 WHERE service_product_id = @service_product_id";
                con.Execute(sql, new { service_product_id = id });
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


    }
}
