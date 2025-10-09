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
    public class AppointmentRepository
    {

        public IEnumerable<AppointmentModel> ShowAllAppointmnets(string status = "") 
        {
            using (var con = Database.GetConnection())
            {

                var sql = string.IsNullOrEmpty(status) || status == "All"
                    ? @"
                    SELECT 
                a.appointment_id AS AppointmentId,
                a.customer_id AS CustomerId,
                CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
                a.stylist_id AS StylistId,
                COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
                sn.serviceName AS Services,
                a.Date AS AppointmentDate,
                a.start_time AS StartTime,
                a.end_time AS EndTime,
                a.Status,
                a.Payment_status AS PaymentStatus,
                a.booking_type AS BookingType
            FROM tbl_appointment a
            LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
            LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
            LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
            LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id;"
                : @"SELECT 
                a.appointment_id AS AppointmentId,
                a.customer_id AS CustomerId,
                CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
                a.stylist_id AS StylistId,
                COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
                sn.serviceName AS Services,
                a.Date AS AppointmentDate,
                a.start_time AS StartTime,
                a.end_time AS EndTime,
                a.Status,
                a.Payment_status AS PaymentStatus,
                a.booking_type AS BookingType
            FROM tbl_appointment a
            LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
            LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
            LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
            LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
            WHERE a.Status = @status;";

                return con.Query<AppointmentModel>(sql, new { status}).ToList();
            }

        }
        
        public IEnumerable<AppointmentModel> GetAllAppointments()
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"
        SELECT 
    a.appointment_id AS AppointmentId,
    a.customer_id AS CustomerId,
    CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
    a.stylist_id AS StylistId,
    COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
    sn.serviceName AS Services,
    a.Date AS AppointmentDate,
    a.start_time AS StartTime,
    a.end_time AS EndTime,
    a.Status,
    a.Payment_status AS PaymentStatus,
    a.booking_type AS BookingType
FROM tbl_appointment a
LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id;";

                return con.Query<AppointmentModel>(sql).ToList();
            }

        }
        public IEnumerable<AppointmentModel> GetAll()
        {

            using (var con = Database.GetConnection())
                    {
                var sql = @"
                SELECT  
    a.appointment_id AS AppointmentId,
    a.customer_id AS CustomerId,
    CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
    c.email AS Email,
    c.phoneNumber AS PhoneNumber,
    a.stylist_id AS StylistId,
    COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
    GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
    SUM(spr.selling_price) AS selling_price,
    SUM(spr.vat_amount) AS vat_amount,
    a.Date AS AppointmentDate,
    a.start_time AS StartTime,
    a.end_time AS EndTime,
    a.Status,
    a.payment_status AS PaymentStatus,
    a.booking_type AS BookingType
FROM tbl_appointment a
LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
GROUP BY a.appointment_id;";

            return con.Query<AppointmentModel>(sql).ToList();
        }

                //            using (var con = Database.GetConnection())
                //            {
                //                var sql = @"
                //        SELECT  
                //    a.appointment_id AS AppointmentId,
                //    a.customer_id AS CustomerId,
                //    CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
                //    c.email AS Email,
                //    c.phoneNumber AS PhoneNumber,
                //    a.stylist_id AS StylistId,
                //    COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
                //    GROUP_CONCAT(sn.serviceName SEPARATOR ', ') AS Services,
                //    spr.selling_price,
                //    spr.vat_amount,
                //    a.Date AS AppointmentDate,
                //    a.start_time AS StartTime,
                //    a.end_time AS EndTime,
                //    a.Status,
                //    a.payment_status AS PaymentStatus,
                //    a.booking_type AS BookingType
                //FROM tbl_appointment a
                //LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
                //LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
                //LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                //LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                //LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                //LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                //GROUP BY a.appointment_id;";

                //                return con.Query<AppointmentModel>(sql).ToList();
                //            }


        }

        public AppointmentModel GetTotalAppointment()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalAppointment FROM tbl_appointment;";
                return con.Query<AppointmentModel>(sql).FirstOrDefault();
            }
        }

        public List<AppointmentModel> GetAppointmentsByDate(DateTime date)
        {
            using (var con = Database.GetConnection())
            {
                var query = @"SELECT start_time, end_time 
                          FROM tbl_appointments 
                          WHERE DATE(Date) = @Date AND Status != 'Cancelled'";

                return con.Query<AppointmentModel>(query, new { Date = date.Date }).ToList();
            }

        }


        public AppointmentModel GetById(int appointmentId)
        {
            using (var con = Database.GetConnection())
            {
                return con.QueryFirstOrDefault<AppointmentModel>(
                   "SELECT * FROM tbl_appointment WHERE appointment_id = @Id",
                   new
                   {
                       Id = appointmentId
                   });
            }

        }

        public int Add(AppointmentModel appointment)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_appointment (customer_id, Date, start_time, end_time, Status, payment_status,booking_type)
                VALUES (@CustomerId, @AppointmentDate, @StartTime, @EndTime, @Status, @PaymentStatus, @BookingType);
                SELECT LAST_INSERT_ID();";

                return con.QuerySingle<int>(sql, appointment);
            }

        }
        public int Update(AppointmentModel appointment) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_appointment 
                    SET customer_id = @CustomerId, 
                        Date = @AppointmentDate, 
                        start_time = @StartTime, 
                        end_time = @EndTime, 
                        Status = @Status, 
                        payment_status = @PaymentStatus, 
                        booking_type = @BookingType 
                    WHERE appointment_id = @AppointmentId;";

                int affectedRows = con.Execute(sql, appointment);

                if (affectedRows == 0)
                {
                    throw new Exception($"Update failed: appointment_id {appointment.AppointmentId} not found.");
                }

                return appointment.AppointmentId;
            }

        }
        public void UpdateStylist(AppointmentModel appointment)
        {
            using (var con = Database.GetConnection())
            {
                con.Execute("UPDATE tbl_appointment SET stylist_id = @StylistId WHERE appointment_id = @AppointmentId", appointment);
            }

        }
        public void UpdatePaymentStatus(AppointmentModel appointment)
        {
            using (var con = Database.GetConnection())
            {
                con.Execute("UPDATE tbl_appointment SET Status = @Status, payment_status = @PaymentStatus WHERE appointment_id = @AppointmentId", appointment);
            }

        }

        public void UpdateStatus(string status, int id)
        {
            using (var con = Database.GetConnection())
            {
                con.Execute("UPDATE tbl_appointment SET Status = @Status WHERE appointment_id = @AppointmentId", new { Status = status, AppointmentId = id });
            }

        }



        // VALIDATION

        public async Task<bool> IsSlotTakenAsync(DateTime date, TimeSpan startTime)
        {
            using (var con = Database.GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM tbl_appointment 
                         WHERE DATE(Date) = @Date AND start_time = @StartTime";

                var parameters = new
                {
                    Date = date.ToString("yyyy-MM-dd"), 
                    StartTime = startTime.ToString(@"hh\:mm\:ss")  
                };

                int count = await con.ExecuteScalarAsync<int>(query, parameters);
                return count > 0;
            }
        }
    }
}
