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

        public IEnumerable<ServiceModel> Get_All_Service() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_servicesname WHERE is_deleted = 0";
                return con.Query<ServiceModel>(sql).ToList();
            }
        }
        public IEnumerable<ServiceModel> getAllServices()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,tbl_servicesname.serviceName, tbl_servicesname.servicePrice, tbl_subcategory.category_id, tbl_servicesname.subcategory_id, tbl_category.categoryName,
tbl_subcategory.subCategoryName,tbl_servicesname.duration, tbl_servicesname.status
                                        FROM tbl_servicesname
                                        LEFT JOIN tbl_subcategory ON tbl_subcategory.subcategory_id = tbl_servicesname.subcategory_id
                                        LEFT JOIN tbl_category ON tbl_category.category_id = tbl_subcategory.category_id
                                        WHERE tbl_servicesname.is_deleted = 0 AND tbl_category.is_deleted = 0 AND tbl_subcategory.is_deleted = 0";
                return con.Query<ServiceModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<ServiceModel>> GetAllServicesAsync(int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,tbl_servicesname.serviceName, tbl_servicesname.servicePrice, tbl_subcategory.category_id, tbl_servicesname.subcategory_id, tbl_category.categoryName,
tbl_subcategory.subCategoryName,tbl_servicesname.duration, tbl_servicesname.status
                                        FROM tbl_servicesname
                                        LEFT JOIN tbl_subcategory ON tbl_subcategory.subcategory_id = tbl_servicesname.subcategory_id
                                        LEFT JOIN tbl_category ON tbl_category.category_id = tbl_subcategory.category_id
                                        WHERE tbl_servicesname.is_deleted = 0 AND tbl_category.is_deleted = 0 AND tbl_subcategory.is_deleted = 0
                                        LIMIT @page_size OFFSET @off_set";
                var result = await con.QueryAsync<ServiceModel>(sql, new { page_size, off_set });

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
                            WHERE tbl_servicesname.serviceName LIKE @key AND tbl_subcategory.is_deleted = 0 AND tbl_servicesname.is_deleted = 0 ";
                return con.Query<ServiceModel>(sql, new { key = $"%{key}%" }).ToList();
            }
        }
        public List<ServiceModel> GetAllServicesbySubcategoryId(int id)
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
                            WHERE tbl_subcategory.subCategory_id = @id AND tbl_subcategory.is_deleted = 0 AND tbl_servicesname.is_deleted = 0 ";
                return con.Query<ServiceModel>(sql, new { id = id }).ToList();
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

        public ServiceModel GetServiceByName(string name)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT tbl_servicesname.serviceName_id,
                            tbl_subcategory.subCategoryName,
                            tbl_servicesname.serviceName,
                            tbl_servicesname.servicePrice,
                            tbl_servicesname.duration 
                            FROM tbl_servicesname
                            LEFT JOIN tbl_subcategory
                            ON tbl_servicesname.subCategory_id = tbl_subcategory.subCategory_id
                            WHERE tbl_servicesname.serviceName = @name AND tbl_subcategory.is_deleted = 0 AND tbl_servicesname.is_deleted = 0 ";
                return con.QueryFirstOrDefault<ServiceModel>(sql, new { name });
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
        public int addService(ServiceModel service)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_servicesname (subCategory_id, serviceName, servicePrice, duration, status) VALUES (@subCategory_id, @serviceName, @servicePrice, @duration, @status);
                            SELECT LAST_INSERT_ID();";
                return con.ExecuteScalar<int>(sql, service);
            }
        }
        public int updateService(ServiceModel service)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET subCategory_id = @subCategory_id, serviceName = @serviceName, servicePrice =@servicePrice, duration = @duration, status = @status WHERE serviceName_id = @serviceName_id";
                return con.Execute(sql, service);
            }
        }
        public int deleteService(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET is_deleted = 1 WHERE serviceName_id = @id";
                return con.Execute(sql, new { id });

            }
        }
        public bool ServiceIsUsed(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_appointment_services WHERE serviceName_id = @id";
                return con.ExecuteScalar<int>(sql, new { id }) > 0;
            }
        }

        public int RestoreService(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_servicesname SET is_deleted = 0 WHERE serviceName_id = @id";
                return con.Execute(sql, new { id });
            }
        }

        public int PermanentDelete(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_servicesname WHERE serviceName_id = @id";
                return con.Execute(sql, new { id });
            }
        }
        public bool ServiceExists(string name, int s_cat_id, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_servicesname WHERE serviceName = @name AND subCategory_id = @s_cat_id AND serviceName_id != @id AND is_deleted = 0";

                return con.ExecuteScalar<int>(sql, new { name, s_cat_id, id }) > 0;
            }
        }
        public int GetServiceAndCategory(string name, int subcat_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT serviceName_id FROM tbL_servicesname WHERE serviceName = @name AND subCategory_id = @subcat_id AND is_deleted = 1 LIMIT 1";
                return con.QueryFirstOrDefault<int>(sql, new { name, subcat_id });
            }
        }

        // LOYALTY CARD SETTINGS

        public IEnumerable<ServiceModel> LoadServicesByServiceAndId()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT serviceName_id, serviceName FROM tbL_servicesname WHERE is_deleted = 0";
                return con.Query<ServiceModel>(sql);
            }
        }

        ///-----------------------------------///


        public bool ServiceSaveWithConsumption(ServiceModel service, IEnumerable<ServiceProductUsageModel> consumption)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        int service_id;
                        if (service.serviceName_id == 0)
                        {
                            service_id = con.ExecuteScalar<int>(
                            @"INSERT INTO tbl_servicesname (subCategory_id, serviceName, servicePrice, duration) 
                      VALUES (@subCategory_id, @serviceName, @servicePrice, @duration);
                      SELECT LAST_INSERT_ID();", service, tx);
                        }
                        else
                        {
                            service_id = service.serviceName_id;
                            con.Execute(
                             @"UPDATE tbl_servicesname
                       SET subCategory_id = @subCategory_id,
                           serviceName = @serviceName,
                           servicePrice = @servicePrice,
                           duration = @duration,
                           status = @status
                       WHERE serviceName_id = @serviceName_id", service, tx);
                        }

                        var consumptionList = consumption.ToList(); // ✅ Avoid multiple enumeration

                        var existingIds = consumptionList
                            .Where(s => s.service_product_id > 0)
                            .Select(s => s.service_product_id)
                            .ToList();

                        if (existingIds.Any())
                        {
                            // ✅ Fixed: column name was serviceName_id but should match service_id FK
                            con.Execute(
                                @"UPDATE tbl_service_product
                          SET is_deleted = 1
                          WHERE service_id = @service_id
                          AND service_product_id NOT IN @existingIds",
                                new { service_id, existingIds }, tx);
                        }
                        else
                        {
                            con.Execute(
                                @"UPDATE tbl_service_product
                          SET is_deleted = 1
                          WHERE service_id = @service_id",
                                new { service_id }, tx);
                        }

                        foreach (var service_consumption in consumptionList)
                        {
                            service_consumption.service_id = service_id;

                            if (service_consumption.service_product_id == 0)
                            {
                                // ✅ Fixed: column names matched to actual DB columns
                                con.Execute(
                                    @"INSERT INTO tbl_service_product 
                              (service_id, product_id, qty_required)
                              VALUES (@service_id, @product_id, @qty_required)",
                                    service_consumption, tx);
                            }
                            else
                            {
                                // ✅ Fixed: update all relevant fields not just product_id and qty
                                con.Execute(
                                    @"UPDATE tbl_service_product
                              SET product_id = @product_id,
                                  qty_required = @qty_required
                              WHERE service_product_id = @service_product_id",
                                    service_consumption, tx);
                            }
                        }

                        tx.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        throw new Exception($"SaveServiceConsumption failed: {ex.Message}", ex);
                    }
                }
            }
        }





    }

    

}



