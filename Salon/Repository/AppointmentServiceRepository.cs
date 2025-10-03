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
                WHERE aps.appointment_id = @AppointmentId
                GROUP BY aps.appointment_id ;";
    

                return con.Query<AppointmentServicesModel>(sql, new { AppointmentId = appointmentId }).ToList();
            }

                
        }


    }
}
