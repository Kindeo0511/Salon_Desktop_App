using Dapper;
using Laundry.Data;
using MySql.Data.MySqlClient;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class BusinessHourRepository
    {

        public BusinessHour GetOpenHour()
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"SELECT * FROM tbl_business_hours";

                return con.QueryFirstOrDefault<BusinessHour>(sql);

            }
        }

        public string CreateOrUpdate(BusinessHour model)
        {
            using (var con = Database.GetConnection())
            {
                // First check if the record exists by primary key
                var existing = con.QuerySingleOrDefault<BusinessHour>(
                    "SELECT * FROM tbl_business_hours WHERE business_hours_id = @business_hours_id",
                    new { model.business_hours_id });

                if (existing == null)
                {
                    // Create (INSERT)
                    var insertSql = @"INSERT INTO tbl_business_hours 
                              (open_time, close_time) 
                              VALUES (@open_time, @close_time);";
                    con.Execute(insertSql, model);
                    return "Business hours record created successfully.";
                }
                else
                {
                    // Update
                    var updateSql = @"UPDATE tbl_business_hours 
                              SET open_time = @open_time, 
                                  close_time = @close_time      
                              WHERE business_hours_id = @business_hours_id;";
                    con.Execute(updateSql, model);
                    return "Business hours record updated successfully.";
                }
            }
        }
    }
    
}
