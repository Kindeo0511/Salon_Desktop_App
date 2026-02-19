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
        public bool IsStylistAvailable(int stylistId, DateTime requestedStart, int durationMinutes)
        {
            
                using (var con = Database.GetConnection())
                {
                    var requestedEnd = requestedStart.AddMinutes(durationMinutes);

                    var sql = @"SELECT COUNT(*) 
                    FROM tbl_appointment_services
                    WHERE stylist_id = @StylistId
                      AND @RequestedStart < end_time
                      AND @RequestedEnd > start_time
                      AND status = 'On Going'";

                    int count = con.ExecuteScalar<int>(sql, new
                    {
                        StylistId = stylistId,
                        RequestedStart = requestedStart,
                        RequestedEnd = requestedEnd
                    });

                    return count == 0; 
                }

            }
        public void DeleteAppointmentServiceByAppointmentId(int appointment_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"DELETE FROM tbl_appointment_services WHERE appointment_id = @appointment_id";
                con.Execute(sql, new { appointment_id = appointment_id });
            }
        }
        public void DeleteAppointmentServiceByAppointmentServiceId(int appointment_service_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_appointment_services WHERE appointment_service_id = @appointment_service_id";
                con.Execute(sql, new { appointment_service_id = appointment_service_id });
            }
        }
        public void AddAppointmentService(AppointmentServicesModel appointmentServices)
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute(@"
                INSERT INTO tbl_appointment_services (appointment_id, serviceName_id, stylist_id, start_time, end_time, status)
                VALUES (@AppointmentId, @ServiceId,@StylistId, @StartTime, @EndTime, @Status);", appointmentServices);
            }
                
        }
        public bool CheckIfServiceExists(int appointmentId, int serviceId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) FROM tbl_appointment_services WHERE appointment_id = @AppointmentId AND serviceName_id = @ServiceId";
                int count = con.ExecuteScalar<int>(sql, new { AppointmentId = appointmentId, ServiceId = serviceId });
                return count > 0;
            }
        }
        public bool MarkAsCompleted(int appointmentServiceId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_appointment_services SET status = 'Completed' WHERE appointment_service_id = @AppointmentServiceId";
                return con.Execute(sql, new { AppointmentServiceId = appointmentServiceId }) > 0;
            }
        }
        public void UpdateAppointmentService(AppointmentServicesModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_appointment_services SET serviceName_id = @ServiceId WHERE appointment_id = @AppointmentId";
                con.Execute(sql, model);
            }
        }
        public bool ChangeStylist(int appointmentServiceId, int newStylistId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_appointment_services SET stylist_id = @NewStylistId WHERE appointment_service_id = @AppointmentServiceId";
                return con.Execute(sql, new { NewStylistId = newStylistId, AppointmentServiceId = appointmentServiceId }) > 0;
            }
        }
        public bool StartWalkInService(int id, DateTime start_time, DateTime end_time)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_appointment_services 
                    SET status = 'On Going', 
                        start_time = @start_time, 
                        end_time = @end_time 
                    WHERE appointment_service_id = @id";

                return con.Execute(sql, new { id, start_time, end_time }) > 0;
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
        public async Task<IEnumerable<AppointmentServicesModel>> GetAllAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT tbl_servicesname.serviceName, COUNT(*) AS bookings
                            FROM tbl_appointment_services
                            LEFT JOIN tbl_servicesname ON tbl_servicesname.serviceName_id = tbl_appointment_services.serviceName_id
                            GROUP BY tbl_servicesname.serviceName;";
                var result = await con.QueryAsync<AppointmentServicesModel>(sql);

                return result.ToList();
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
                    s.stylist_id AS StylistId,
                    s.firstName,
                    s.lastName,
                    sn.duration AS Duration,
                    sn.servicePrice AS SellingPrice,
                    MAX(spr.vat_amount) AS VatAmount,
                    aps.start_time AS StartTime,
                    aps.end_time AS EndTime,
                    aps.status
        
                FROM tbl_appointment_services aps
                INNER JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
                LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                LEFT JOIN tbl_stylists s ON s.stylist_id = aps.stylist_id
                WHERE aps.appointment_id = @AppointmentId
                GROUP BY aps.appointment_service_id, aps.appointment_id, aps.serviceName_id, sn.serviceName;
                
                ";


                return con.Query<AppointmentServicesModel>(sql, new { AppointmentId = appointmentId }).ToList();
            }


        }

        //public IEnumerable<AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId)
        //{
        //    using (var con = Database.GetConnection()) 
        //    {
        //        var sql = @"SELECT 
        //            aps.appointment_service_id AS AppointmentServiceId,
        //            aps.appointment_id AS AppointmentId,
        //            aps.serviceName_id AS ServiceId,
        //            sn.serviceName AS ServiceName,
        //            spr.selling_price AS SellingPrice,
        //            spr.vat_amount AS VatAmount
        //        FROM tbl_appointment_services aps
        //        INNER JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
        //        LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
        //        LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
        //        WHERE aps.appointment_id = @AppointmentId";


        //        return con.Query<AppointmentServicesModel>(sql, new { AppointmentId = appointmentId }).ToList();
        //    }


        //}
        public IEnumerable<AppointmentServicesModel> GetViewSelectedServices(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT DISTINCT
                        aps.appointment_service_id AS AppointmentServiceId,
                        aps.appointment_id AS AppointmentId,
                        aps.serviceName_id AS ServiceId,
                        s.firstName,
                        s.lastName,
                        sn.serviceName AS ServiceName,
                        sn.duration AS Duration,
                        aps.start_time AS StartTime,
                        aps.end_time AS EndTime,
                        aps.status
                    FROM tbl_appointment_services aps
                    INNER JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
                    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                    LEFT JOIN tbl_stylists s ON s.stylist_id = aps.stylist_id
                    WHERE aps.appointment_id = @id
                    ;";
                return con.Query<AppointmentServicesModel>(sql, new { id = id }).ToList();
            }
        }
        public IEnumerable<AppointmentServicesModel>  ServicesSelected(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT * FROM  tbl_item WHERE item_id= @id;";
                return con.Query<AppointmentServicesModel>(sql, new { id = id}).ToList();
            }
        }


    }

}
