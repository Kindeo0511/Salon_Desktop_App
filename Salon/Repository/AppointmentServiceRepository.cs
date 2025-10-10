using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Salon.Repository
{
    public class AppointmentServiceRepository : IAppointmentServiceRepository
    {
        public void AddAppointmentService(AppointmentServicesModel appointmentServices)
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute(@"
                INSERT INTO tbl_appointment_services (appointment_id, serviceName_id)
                VALUES (@AppointmentId, @ServiceId);", appointmentServices);
            }
                
        }
        public void ClearDeleteAllServicesForAppointment(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                DELETE FROM tbl_appointment_services WHERE appointment_id = @id;";
               con.Execute(sql, new { id = id});
            }
        }
        public IEnumerable<AppointmentServicesModel> AppointmentServicesSelected(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_appointment_services WHERE appointment_id =@AppointmentId";
                return con.Query<AppointmentServicesModel>(sql).ToList();
            }
        }

        public IEnumerable<AppointmentServicesModel> GetAll() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT tbl_servicesname.serviceName, COUNT(*) AS bookings
                            FROM tbl_appointment_services
                            LEFT JOIN tbl_servicesname ON tbl_servicesname.serviceName_id = tbl_appointment_services.serviceName_id
                            GROUP BY tbl_servicesname.serviceName;";
                return con.Query<AppointmentServicesModel>(sql).ToList();
            }
        }
        public IEnumerable<AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                    aps.appointment_service_id AS AppointmentServiceId,
                    aps.appointment_id AS AppointmentId,
                    aps.serviceName_id AS ServiceId,
                    sn.serviceName AS ServiceName,
                    spr.selling_price AS SellingPrice,
                    spr.vat_amount AS VatAmount
                FROM tbl_appointment_services aps
                INNER JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
                LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                WHERE aps.appointment_id = @AppointmentId";
    

                return con.Query<AppointmentServicesModel>(sql, new { AppointmentId = appointmentId }).ToList();
            }

                
        }

        public IEnumerable<AppointmentServicesModel> ServicesSelected(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                        sn.serviceName_id AS ServiceId,
                        sn.serviceName AS ServiceName,
                        sn.subCategory_id,
                        sc.subCategoryName AS SubCategoryname,
                        sn.duration AS Duration
                    FROM tbl_appointment_services aps
                    LEFT JOIN tbl_appointment a ON a.appointment_id = aps.appointment_id
                    LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                    LEFT JOIN tbl_subcategory sc ON sn.subCategory_id = sc.subCategory_id
                    WHERE aps.appointment_id = @id;";
                return con.Query<AppointmentServicesModel>(sql, new { id = id}).ToList();
            }
        }


    }
}
