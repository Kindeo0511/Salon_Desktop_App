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
    public class WalkInRepository : IWalkIn
    {
       public IEnumerable<WalkInModel> GetWalkIn()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                            w.id,
                            w.name,
                            sn.servicename_id AS serviceName_id,
                            sn.serviceName,
                            sn.subCategory_id AS SubCategoryId,
                            (sn.servicePrice) AS selling_price,
                            w.stylist_id,
                            CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName) AS StylistName,
                            w.date,
                            w.start_time ,
                            w.end_time,
                            w.status,
                            w.payment_status	 
                        FROM tbl_walk_in w
                        LEFT JOIN tbl_stylists s ON w.stylist_id = s.stylist_id
                        LEFT JOIN tbl_servicesname sn ON w.serviceName_id = sn.serviceName_id

                        ";
                return con.Query<WalkInModel>(sql).ToList();
            }
        }
        public int getWalkInCode() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT IFNULL(MAX(appointment_id), 0) + 1 FROM tbl_appointment";
                return con.ExecuteScalar<int>(sql);
            }
               
        }
        public void AddWalkIn(WalkInModel walkIn)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_walk_in (name, stylist_id, serviceName_id, date, start_time, end_time, status, payment_status, cancel_request) 
                          VALUES (@name, @stylist_id, @serviceName_id, @date, @start_time, @end_time, @status, @payment_status, @cancel_request)";
                con.Execute(sql, walkIn);
            }
        }
        public void UpdateWalkIn(WalkInModel walkIn)
        {
           using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_walk_in 
                          SET name = @name, stylist_id = @stylist_id, serviceName_id = @serviceName_id, date =@date, start_time = @start_time, end_time = @end_time, 
                              status = @status, payment_status = @payment_status, cancel_request = @cancel_request
                          WHERE id = @id";
                con.Execute(sql, walkIn);
            }
        }
        public void DeleteWalkIn(int id)
        {
            throw new NotImplementedException();
        }
    }
}
