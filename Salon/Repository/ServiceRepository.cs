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
    public class ServiceRepository
    {
        public IEnumerable<ServiceModel> getAllServices()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,tbl_servicesname.serviceName, tbl_subcategory.category_id, tbl_servicesname.subcategory_id, tbl_category.categoryName,
tbl_subcategory.subCategoryName,tbl_servicesname.duration, tbl_servicesname.status
                                        FROM tbl_servicesname
                                        LEFT JOIN tbl_subcategory ON tbl_subcategory.subcategory_id = tbl_servicesname.subcategory_id
                                        LEFT JOIN tbl_category ON tbl_category.category_id = tbl_subcategory.category_id
                                        WHERE tbl_servicesname.is_deleted = 0";
                return con.Query<ServiceModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<ServiceModel>> GetAllServicesAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,tbl_servicesname.serviceName, tbl_subcategory.category_id, tbl_servicesname.subcategory_id, tbl_category.categoryName,
tbl_subcategory.subCategoryName,tbl_servicesname.duration, tbl_servicesname.status
                                        FROM tbl_servicesname
                                        LEFT JOIN tbl_subcategory ON tbl_subcategory.subcategory_id = tbl_servicesname.subcategory_id
                                        LEFT JOIN tbl_category ON tbl_category.category_id = tbl_subcategory.category_id
                                        WHERE tbl_servicesname.is_deleted = 0";
                var result = await con.QueryAsync<ServiceModel>(sql);

                return result.ToList();
            }
        }
        public List<ServiceModel> GetAllServicesByName(string key = "")
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,
	                        tbl_subcategory.subCategoryName,
                            tbl_servicesname.serviceName,
                            tbl_servicesname.servicePrice,
	                        tbl_servicesname.duration,
                            tbl_servicesname.status
                            FROM tbl_servicesname
                            LEFT JOIN tbl_subcategory
                            ON tbl_servicesname.subCategory_id = tbl_subcategory.subCategory_id
                            WHERE tbl_servicesname.serviceName LIKE @key ";
                return con.Query<ServiceModel>(sql, new {key =$"%{key}%" }).ToList();
            }
        }
        public ServiceModel GetTotalServices() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) AS TotalService FROM tbl_servicesname";
                return con.Query<ServiceModel>(sql).FirstOrDefault();
            }
        }

        public async Task<ServiceModel> GetTotalServicesAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalService FROM tbl_servicesname";
                var result = await con.QueryAsync<ServiceModel>(sql);

                return result.FirstOrDefault();
            }
        }
        public void addService(ServiceModel service)
        {
           using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_servicesname (subCategory_id, serviceName, duration, status) VALUES (@subCategory_id, @serviceName, @duration, @status)";
                con.Execute(sql, service);
            }
        }
        public void updateService(ServiceModel service)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET subCategory_id = @subCategory_id, serviceName = @serviceName, duration = @duration, status = @status WHERE serviceName_id = @serviceName_id";
                con.Execute(sql, service);
            }
        }
        public void deleteService(int id)
        {
           using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET is_deleted = 1 WHERE serviceName_id = @id";
                con.Execute(sql, new { id });
            }
        }

        public void RestoreService(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET is_deleted = 0 WHERE serviceName_id = @id";
                con.Execute(sql, new { id });
            }
        }

        public bool ServiceExists(string name, int s_cat_id, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_servicesname WHERE serviceName = @name AND subCategory_id = @s_cat_id AND serviceName_id != @id";

                return con.ExecuteScalar<int>(sql, new { name, s_cat_id, id }) > 0;
            }
        }
    }
}
