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
    public  class AppointmentReportRepository : IAppointment
    {
        public AppointmentModel TopSpender() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT CONCAT(c_a.firstName,' ',c_a.middleName,' ',c_a.lastName) AS ClientName, SUM(p.total_amount) AS TotalSpent
                            FROM tbl_customer_account c_a
                            JOIN tbl_appointment a ON c_a.customer_id = a.customer_id
                            JOIN tbl_payment p ON p.appointment_id = a.appointment_id
                            GROUP BY ClientName
                            ORDER BY TotalSpent DESC
                            LIMIT 1;
                            ";
                return con.Query<AppointmentModel>(sql).FirstOrDefault();
            }
        }
        public AppointmentModel TopSpender(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT CONCAT(c_a.firstName,' ',c_a.middleName,' ',c_a.lastName) AS ClientName, SUM(p.total_amount) AS TotalSpent
                            FROM tbl_customer_account c_a
                            JOIN tbl_appointment a ON c_a.customer_id = a.customer_id
                            JOIN tbl_payment p ON p.appointment_id = a.appointment_id
                            WHERE p.paid_at BETWEEN @start AND @end
                            GROUP BY ClientName
                            ORDER BY TotalSpent DESC
                            LIMIT 1;
                            ";
                return con.Query<AppointmentModel>(sql, new { start = start , end = end}).FirstOrDefault();
            }
        }

        public AppointmentModel RepeatClient() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM (
                            SELECT customer_id
                            FROM tbl_appointment
                            GROUP BY customer_id
                            HAVING COUNT(*) >= 2
                        ) AS RepeatClient;
                        ";
                return con.Query<AppointmentModel>(sql).FirstOrDefault();
            }
        }
        public AppointmentModel RepeatClient(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM (
                            SELECT customer_id
                            FROM tbl_appointment
                            WHERE Date BETWEEN @start AND @end
                            GROUP BY customer_id
                            HAVING COUNT(*) >= 2
                        ) AS RepeatClient;
                        ";
                return con.Query<AppointmentModel>(sql, new { start = start, end = end}).FirstOrDefault();
            }
        }

        public IEnumerable<AppointmentModel> CustomerVisit() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                            CONCAT(c.firstName,' ',c.middleName,' ',c.lastName) AS ClientName,
                            COUNT(a.appointment_id) AS Visit,
                            SUM(p.total_amount) AS TotalSpend,
                            MAX(a.Date) AS LastVisit
                        FROM tbl_customer_account c
                        INNER JOIN tbl_appointment a ON c.customer_id = a.customer_id
                        LEFT JOIN tbl_payment p ON p.appointment_id = a.appointment_id
                        GROUP BY c.customer_id, ClientName;";
                return con.Query<AppointmentModel>(sql).ToList();
            }
        }
        public IEnumerable<AppointmentModel> CustomerVisit(DateTime start, DateTime end) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            CONCAT(c.firstName,' ',c.middleName,' ',c.lastName) AS ClientName,
                            COUNT(a.appointment_id) AS Visit,
                            SUM(p.total_amount) AS TotalSpend,
                            MAX(a.Date) AS LastVisit
                        FROM tbl_customer_account c
                        INNER JOIN tbl_appointment a ON c.customer_id = a.customer_id
                        LEFT JOIN tbl_payment p ON p.appointment_id = a.appointment_id
                        WHERE a.date BETWEEN @start AND @end
                        GROUP BY c.customer_id, ClientName;";
                return con.Query<AppointmentModel>(sql, new {start = start, end = end }).ToList();
            }
        }
    }
}
