using Dapper;
using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using Laundry.Data;
using MySql.Data.MySqlClient;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        isc.stylist_id AS StylistId,
        COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
         c.email As Email,
         c.phoneNumber AS PhoneNumber,
         c.loyalty_points AS LoyaltyPoints,
        sn.subCategory_id AS SubCategoryId,
         sn.servicename_id As ServiceId,
        GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
        (sn.servicePrice) AS selling_price,
        SUM(spr.vat_amount) AS vat_amount,
        a.Date AS AppointmentDate,
        a.start_time AS StartTime,
        a.end_time AS EndTime,
        a.Status,
        a.Payment_status AS PaymentStatus,
        a.customer_type AS CustomerType
    FROM tbl_appointment a
    LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
    LEFT JOIN tbl_servicesname sn ON a.serviceName_id = sn.serviceName_id
    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
    LEFT JOIN tbl_invoice i ON i.appointment_id = a.appointment_id
    LEFT JOIN tbl_invoice_service_cart isc ON isc.invoice_id = i.invoice_id
    LEFT JOIN tbl_stylists s ON s.stylist_id = isc.stylist_id
    GROUP BY 
        a.appointment_id,
        a.customer_id,
        isc.stylist_id,
        a.Date,
        a.start_time,
        a.end_time,
        a.Status,
        a.Payment_status,
        a.customer_type;"
                  : @"SELECT 
                a.appointment_id AS AppointmentId,
                a.customer_id AS CustomerId,
                CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
                isc.stylist_id AS StylistId,
                COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
                 c.email As Email,
                 c.phoneNumber AS PhoneNumber,
                c.loyalty_points AS LoyaltyPoints,
                sn.subCategory_id AS SubCategoryId,
                 sn.servicename_id As ServiceId,
                GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
                (sn.servicePrice) AS selling_price,
                SUM(spr.vat_amount) AS vat_amount,
                a.Date AS AppointmentDate,
                a.start_time AS StartTime,
                a.end_time AS EndTime,
                a.Status,
                a.Payment_status AS PaymentStatus,
                a.customer_type AS CustomerType
            FROM tbl_appointment a
            LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
            LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
            LEFT JOIN tbl_servicesname sn ON a.serviceName_id = sn.serviceName_id
            LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
            LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
            LEFT JOIN tbl_invoice i ON i.appointment_id = a.appointment_id
            LEFT JOIN tbl_invoice_service_cart isc ON isc.invoice_id = i.invoice_id
            LEFT JOIN tbl_stylists s ON s.stylist_id = isc.stylist_id
            WHERE a.Status = @status
          GROUP BY 
                a.appointment_id,
                a.customer_id,
                isc.stylist_id,
                a.Date,
                a.start_time,
                a.end_time,
                a.Status,
                a.Payment_status,
                c.customer_type;";

                return con.Query<AppointmentModel>(sql, new { status}).ToList();
            }

        }

        public async Task<IEnumerable<AppointmentModel>> ShowAllAppointmentAsync(string status = "", int page_size = 0, int off_set = 0) 
        {
            using (var con = Database.GetConnection())
            {

                var sql = string.IsNullOrEmpty(status) || status == "All"
      ? @"
     SELECT 
     a.appointment_id AS AppointmentId,
     a.customer_id AS CustomerId,
     CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
     a.Date AS AppointmentDate,
     a.start_time AS StartTime,
     a.end_time AS EndTime,
     a.appointment_type AS AppointmentType,
     a.Status,
     a.Payment_status AS PaymentStatus,
     a.customer_type AS CustomerType
 FROM tbl_appointment a
 LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
 WHERE a.Status IS NOT NULL AND a.appointment_type = 'Appointment'

    LIMIT @page_size OFFSET @off_set
        ;"
                  : @" SELECT 
     a.appointment_id AS AppointmentId,
     a.customer_id AS CustomerId,
     CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
     a.Date AS AppointmentDate,
     a.start_time AS StartTime,
     a.end_time AS EndTime,
     a.appointment_type AS AppointmentType,
     a.Status,
     a.Payment_status AS PaymentStatus,
     a.customer_type AS CustomerType
 FROM tbl_appointment a
 LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
 WHERE a.Status IS NOT NULL AND a.appointment_type = 'Appointment'

    LIMIT @page_size OFFSET @off_set
                ;";

                var result = await con.QueryAsync<AppointmentModel>(sql, new { status, page_size, off_set });

                return result.ToList();
            }

        }

      
        public IEnumerable<AppointmentModel> ShowWaitingQueue() 
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"
    SELECT 
        a.appointment_id AS AppointmentId,
        a.customer_id AS CustomerId,
        CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
        isc.stylist_id AS StylistId,
        COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
         c.email As Email,
         c.phoneNumber AS PhoneNumber,
            c.loyalty_points AS LoyaltyPoints,
        sn.subCategory_id AS SubCategoryId,
         sn.servicename_id As ServiceId,
        GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
       (sn.servicePrice) AS selling_price,
        SUM(spr.vat_amount) AS vat_amount,
        a.Date AS AppointmentDate,
        a.start_time AS StartTime,
        a.end_time AS EndTime,
        aps.status As Status,
        a.Payment_status AS PaymentStatus,
        a.customer_type AS CustomerType
    FROM tbl_appointment a
    LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
    LEFT JOIN tbl_servicesname sn ON a.serviceName_id = sn.serviceName_id
    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
    LEFT JOIN tbl_invoice i ON i.appointment_id = a.appointment_id
    LEFT JOIN tbl_invoice_service_cart isc ON isc.invoice_id = i.invoice_id
    LEFT JOIN tbl_stylists s ON s.stylist_id = isc.stylist_id
    GROUP BY 
        a.appointment_id,
        a.customer_id,
        isc.stylist_id,
        a.Date,
        a.start_time,
        a.end_time,
        aps.status,
        a.Payment_status,
        a.customer_type
    
        ;";


                var result = con.Query<AppointmentModel>(sql);

                return result.ToList();
            }

        }
        public IEnumerable<AppointmentModel> ShowOnGoingQueue() 
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"
             SELECT 
            a.appointment_id AS AppointmentId,
            a.customer_id AS CustomerId,
            CONCAT(ca.firstName, ' ', ca.middleName, ' ', ca.lastName) AS CustomerName,
            a.customer_type AS CustomerType,
            aps.servicename_id AS ServiceId,
            aps.stylist_id AS StylistId,
            COALESCE(CONCAT(s.firstName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
            a.Date AS AppointmentDate,
            aps.start_time AS StartTime,
            aps.end_time AS EndTime,
            a.appointment_type AS AppointmentType,
            sn.duration AS Duration,
            a.Payment_status AS PaymentStatus,
            a.Status AS AppointmentStatus,
            aps.status AS Status
        FROM tbl_appointment a
        LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
        LEFT JOIN tbl_servicesname sn ON aps.servicename_id = sn.serviceName_id
        LEFT JOIN tbl_stylists s ON s.stylist_id = aps.stylist_id
        LEFT JOIN tbl_customer_account ca on ca.customer_id = a.customer_id
        WHERE aps.status = 'On Going' OR aps.status = 'Completed' AND a.payment_status != 'Paid'
          AND DATE(a.Date) = CURDATE()
          GROUP BY a.appointment_id
                ;";


                var result = con.Query<AppointmentModel>(sql);

                return result.ToList();
            }
        }

        public IEnumerable<AppointmentModel> ShowQueue()
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"
            SELECT DISTINCT
    a.appointment_id AS AppointmentId,
    a.customer_id AS CustomerId,
    CONCAT (ca.firstName, "" "", ca.lastName) AS CustomerName,
    a.start_time AS StartTime,
    a.end_time AS EndTime,
    a.appointment_type AS AppointmentType,
    a.customer_type AS CustomerType,
    a.Payment_status AS PaymentStatus,
    a.status AS Status
FROM tbl_appointment a
LEFT JOIN tbl_customer_account ca on ca.customer_id = a.customer_id
WHERE a.status IN ('Waiting','On Going', 'Scheduled') 
  AND DATE(a.Date) = CURDATE()

    
    
        ;";


                var result = con.Query<AppointmentModel>(sql);

                return result.ToList();
            }

        }
        //        public IEnumerable<AppointmentModel> ShowQueue() 
        //        {
        //            using (var con = Database.GetConnection())
        //            {

        //                var sql = @"
        //      SELECT DISTINCT
        //    a.appointment_id AS AppointmentId,
        //    a.customer_id AS CustomerId,
        //    CONCAT (ca.firstName, "" "", ca.lastName) AS CustomerName,
        //    aps.appointment_service_id AS AppointmentServiceId,
        //    aps.servicename_id AS ServiceId,
        //    sn.serviceName AS ServiceName,
        //    aps.stylist_id AS StylistId,
        //    COALESCE(CONCAT(s.firstName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
        //    aps.start_time AS StartTime,
        //    aps.end_time AS EndTime,
        //    a.appointment_type AS AppointmentType,
        //    a.customer_type AS CustomerType,
        //    sn.duration AS Duration,
        //    a.Payment_status AS PaymentStatus,
        //    aps.status AS Status
        //FROM tbl_appointment a
        //LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
        //LEFT JOIN tbl_servicesname sn ON aps.servicename_id = sn.serviceName_id
        //LEFT JOIN tbl_stylists s ON s.stylist_id = aps.stylist_id
        //LEFT JOIN tbl_customer_account ca on ca.customer_id = a.customer_id
        //WHERE a.status IN ('Waiting','On Going', 'Scheduled') 
        //  AND DATE(a.Date) = CURDATE()

        //  GROUP BY a.appointment_id, aps.appointment_service_id


        //        ;";


        //                var result =  con.Query<AppointmentModel>(sql);

        //                return result.ToList();
        //            }

        //        }

        public IEnumerable<AppointmentModel> GetAllAppointments()
        {
            using (var con = Database.GetConnection())
            {

                var sql = @"
        SELECT 
    a.appointment_id AS AppointmentId,
    a.customer_id AS CustomerId,
    CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
    isc.stylist_id AS StylistId,
    COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
    sn.subCategory_id AS SubCategoryId,
     sn.servicename_id As ServiceId,
    sn.serviceName AS Services,
    a.Date AS AppointmentDate,
    a.start_time AS StartTime,
    a.end_time AS EndTime,
    a.Status,
    a.Payment_status AS PaymentStatus
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
    sn.subCategory_id AS SubCategoryId,
    sn.servicename_id As ServiceId,
    GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
    sn.servicePrice) AS selling_price,
    SUM(spr.vat_amount) AS vat_amount,
    a.Date AS AppointmentDate,
    a.start_time AS StartTime,
    a.end_time AS EndTime,
    a.Status,
    a.payment_status AS PaymentStatus
    a.customer_type AS CustomerType
FROM tbl_appointment a
LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
LEFT JOIN tbl_servicesname sn ON a.serviceName_id = sn.serviceName_id
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
        public IEnumerable<AppointmentModel> GetTodayAppointment() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                    a.appointment_id AS AppointmentId,
                    a.customer_id AS CustomerId,
                    CONCAT(c.firstName, ' ', c.middleName, ' ', c.lastName) AS CustomerName,
                    a.stylist_id AS StylistId,
                    COALESCE(CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName), 'Stylist not assigned yet') AS StylistName,
                    c.email AS Email,
                    c.phoneNumber AS PhoneNumber,
                    c.customer_type AS CustomerType,
                    GROUP_CONCAT(DISTINCT sn.serviceName SEPARATOR ', ') AS Services,
                    SUM(sn.servicePrice) AS TotalSellingPrice,
                    SUM(spr.vat_amount) AS TotalVatAmount,
                    a.Date AS AppointmentDate,
                    a.start_time AS StartTime,
                    a.end_time AS EndTime,
                    a.Status,
                    a.Payment_status AS PaymentStatus
                FROM tbl_appointment a
                LEFT JOIN tbl_customer_account c ON a.customer_id = c.customer_id
                LEFT JOIN tbl_stylists s ON a.stylist_id = s.stylist_id
                LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                WHERE a.Date = CURRENT_DATE() AND a.payment_status != 'Paid'
                GROUP BY 
                    a.appointment_id,
                    a.customer_id,
                    a.stylist_id,
                    a.Date,
                    a.start_time,
                    a.end_time,
                    a.Status,
                    a.Payment_status,
                    a.customer_type;
                ";
                return con.Query<AppointmentModel>(sql).ToList();
            }
        }
        public bool GetStylistStatus(int stylistId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
            SELECT 
                CASE 
                    WHEN a_s.status = 'On Going' THEN 1
                    ELSE 0
                END AS IsAvailable
            FROM tbl_stylists s
            LEFT JOIN tbl_appointment_services a_s  
                   ON a_s.stylist_id = s.stylist_id
                   AND DATE(a_s.start_time) = CURRENT_DATE()
                   AND a_s.start_time = (
                       SELECT MAX(start_time)
                       FROM tbl_appointment_services
                       WHERE stylist_id = s.stylist_id
                         AND DATE(start_time) = CURRENT_DATE()
                   )
            WHERE s.stylist_id = @stylistId;
        ";

                int dutyFlag = con.ExecuteScalar<int>(sql, new { stylistId });
                return dutyFlag == 1; // true if off duty
     
            }
        }
        public bool IsStylistOffDuty(int stylistId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COALESCE(MAX(ss.is_duty), 0) AS is_on_duty
FROM tbl_stylist_schedules ss
WHERE ss.stylist_id = @stylistId
  AND ss.weekly_id = (WEEKDAY(CURDATE()) + 1);";
                int dutyFlag = con.ExecuteScalar<int>(sql, new { stylistId });
                return dutyFlag == 1; // true if off duty
            }
        }



        public IEnumerable<AppointmentModel> StylistTrackingPanel() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
    s.stylist_id,
    CASE 
        WHEN a_s.status = 'On Going' THEN a.appointment_id
        ELSE NULL
    END AS AppointmentId,
    CONCAT(s.firstName, ' ', s.lastName) AS StylistName,
    CASE 
        WHEN a_s.status = 'On Going' THEN COALESCE(CONCAT(ca.firstName, ' ', ca.lastName), '')
        ELSE ''
    END AS CustomerName,
    CASE 
        WHEN a_s.status = 'On Going' THEN COALESCE(sn.serviceName, '')
        ELSE ''
    END AS Services,
    CASE 
        WHEN a_s.status = 'On Going' THEN a_s.start_time
        ELSE NULL
    END AS StartTime,
    CASE 
        WHEN a_s.status = 'On Going' THEN a_s.end_time
        ELSE NULL
    END AS EndTime,
    CASE 
        WHEN a_s.status = 'On Going' THEN a.appointment_type
        ELSE NULL
    END AS AppointmentType,
    CASE 
        WHEN a_s.status = 'On Going' THEN a_s.status
        ELSE NULL
    END AS Status,
    CASE 
        WHEN a_s.status = 'On Going' THEN 'Busy'
        ELSE 'Available'
    END AS DutyStatus
FROM tbl_stylists s
LEFT JOIN tbl_appointment_services a_s 
       ON a_s.stylist_id = s.stylist_id
       AND DATE(a_s.start_time) = CURRENT_DATE()
       AND a_s.start_time = (
           SELECT MAX(start_time)
           FROM tbl_appointment_services
           WHERE stylist_id = s.stylist_id
             AND DATE(start_time) = CURRENT_DATE()
       )
LEFT JOIN tbl_appointment a   
       ON a.appointment_id = a_s.appointment_id
LEFT JOIN tbl_customer_account ca   
       ON ca.customer_id = a.customer_id
LEFT JOIN tbl_servicesname sn   
       ON sn.serviceName_id = a_s.serviceName_id
";
//WHERE s.is_duty = 1
                          
                return con.Query<AppointmentModel>(sql).ToList();
            }

//            SELECT
//    s.stylist_id,
//    a.appointment_id AS AppointmentId,
//    CONCAT(s.firstName, ' ', s.lastName) AS StylistName,
//    COALESCE(CONCAT(ca.firstName, ' ', ca.lastName), '-') AS CustomerName,
//    COALESCE(sn.serviceName, '-') AS Services,
//    a_s.start_time AS StartTime,
//    a_s.end_time AS EndTime,
//    a.appointment_type AS AppointmentType,
//    a_s.status AS Status,
//    CASE
//        WHEN a_s.status = 'On Going' THEN 'Busy'
//        ELSE 'Available'
//    END AS DutyStatus
//FROM tbl_stylists s
//LEFT JOIN tbl_appointment_services a_s
//       ON a_s.stylist_id = s.stylist_id
//       AND DATE(a_s.start_time) = CURRENT_DATE()
//       AND a_s.start_time = (
//           SELECT MAX(start_time)
//           FROM tbl_appointment_services
//           WHERE stylist_id = s.stylist_id
//             AND DATE(start_time) = CURRENT_DATE()
           	 
//       )
//LEFT JOIN tbl_appointment a
//       ON a.appointment_id = a_s.appointment_id
//LEFT JOIN tbl_customer_account ca
//       ON ca.customer_id = a.customer_id
//LEFT JOIN tbl_servicesname sn
//       ON sn.serviceName_id = a_s.serviceName_id
//WHERE s.is_duty = 1;
        }
        public AppointmentModel GetTotalAppointment()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalAppointment FROM tbl_appointment;";
                return con.Query<AppointmentModel>(sql).FirstOrDefault();
            }
        }
        public async Task<AppointmentModel> GetTotalAppointmentAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalAppointment FROM tbl_appointment;";
                var result =  await con.QueryAsync<AppointmentModel>(sql);

                return result.FirstOrDefault();
            }
        }
        public List<AppointmentModel> GetAppointmentsByDate(DateTime date)
        {
            using (var con = Database.GetConnection())
            {
                var query = @"SELECT start_time, end_time 
                          FROM tbl_appointment
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
                var sql = @"
            INSERT INTO tbl_appointment 
                (customer_id, Date, start_time, end_time,appointment_type, Status, payment_status,customer_type)
            VALUES 
                (@CustomerId, @AppointmentDate, @StartTime, @EndTime,@AppointmentType, @Status, @PaymentStatus, @CustomerType);
            SELECT LAST_INSERT_ID();
        ";

                // QuerySingle will return the new ID
                int newId = con.QuerySingle<int>(sql, appointment);
                return newId;
            }
        }
        public int AddWalkIn(AppointmentModel appointment)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
            INSERT INTO tbl_appointment 
                ( Date, start_time, end_time,appointment_type, Status, payment_status,customer_type)
            VALUES 
                ( @AppointmentDate, @StartTime, @EndTime,@AppointmentType, @Status, @PaymentStatus, @CustomerType);
            SELECT LAST_INSERT_ID();
        ";

                // QuerySingle will return the new ID
                int newId = con.QuerySingle<int>(sql, appointment);
                return newId;
            }
        }
        public void UpdateAppointmentStatus(int AppointmentId, string status) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_appointment
                        SET Status = @Status                   
                        WHERE appointment_id = @AppointmentId";
                con.Execute(sql, new { AppointmentId, status});
            }
        }
        public void UpdateAppointment(AppointmentModel appointment) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_appointment
                        SET 
                        Date = @AppointmentDate,
                        start_time = @StartTime,
                        end_time = @EndTime
                        WHERE appointment_id = @AppointmentId";
                con.Execute(sql, appointment);
            }
        }
        public void UpdateWalkin(AppointmentModel appointment)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_appointment
                        SET Date = @AppointmentDate,
                        start_time = @StartTime,
                        end_time = @EndTime
                        WHERE appointment_id = @AppointmentId";
                con.Execute(sql, appointment);
            }
        }
        public int Update(AppointmentModel appointment) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_appointment 
                    SET customer_id = @CustomerId,
                        stylist_id = @StylistId,
                        serviceName_id = @ServiceId,
                        Date = @AppointmentDate, 
                        start_time = @StartTime, 
                        end_time = @EndTime, 
                        Status = @Status, 
                        payment_status = @PaymentStatus, 
                        customer_type = @CustomerType 
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
        public IEnumerable<AppointmentModel> GetAppointment(int stylist_id, DateTime date) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT start_time AS StartTime, end_time AS EndTime  FROM tbl_appointment WHERE stylist_id = @StylistId AND DATE(Date) = @Date";
                return con.Query<AppointmentModel>(sql, new
                {
                    StylistId = stylist_id,
                    Date = date.ToString("yyyy-MM-dd")
                }).ToList();
              
            }
        }
        public async Task<bool> CustomerIsAlreadyBooked(DateTime date, TimeSpan startTime, TimeSpan duration, int customerId)
        {
            using (var con = Database.GetConnection())
            {
                TimeSpan endTime = startTime.Add(duration);

                string query = @"
            SELECT COUNT(*) FROM tbl_appointment
            WHERE DATE(Date) = @Date
              AND customer_id = @CustomerId
              AND (
                  (@StartTime BETWEEN start_time AND end_time) OR
                  (@EndTime BETWEEN start_time AND end_time) OR
                  (start_time BETWEEN @StartTime AND @EndTime)
              )";

                var parameters = new
                {
                    Date = date.ToString("yyyy-MM-dd"),
                    StartTime = startTime.ToString(@"hh\:mm\:ss"),
                    EndTime = endTime.ToString(@"hh\:mm\:ss"),
                    CustomerId = customerId
                };

                int count = await con.ExecuteScalarAsync<int>(query, parameters);
                return count > 0;
            }
        }
    }
}
