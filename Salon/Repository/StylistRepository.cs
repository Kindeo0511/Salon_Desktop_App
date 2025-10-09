using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Salon.Repository
{
    public class StylistRepository : IStylist
    {
        public IEnumerable<StylistModel> GetAllStylist()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_stylists";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public IEnumerable<StylistModel> GetStylistWithFullName()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT stylist_id, CONCAT(firstName,' ',middleName,' ',lastName) as fullName FROM tbl_stylists";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public StylistModel GetStylistCost()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT ROUND(AVG(daily_wage), 0) AS stylist_cost
                            FROM tbl_stylists;
                            ";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }
        public void AddStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stylists (firstName, middleName, lastName, birth_date, contactNumber, email, address, daily_wage) 
                            VALUES (@firstName, @middleName, @lastName, @birth_date, @contactNumber, @email, @address, @daily_wage)";
                con.Execute(sql, stylist);
            }
        }
        public void UpdateStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_stylists SET firstName = @firstName, middleName = @middleName, lastName = @lastName, 
                            birth_date = @birth_date, contactNumber = @contactNumber, email = @email, address = @address, daily_wage = @daily_wage
                            WHERE stylist_id = @stylist_id";
                con.Execute(sql, stylist);
            }
        }
        public void DeleteStylist(int stylist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_stylists WHERE stylist_id = @stylist_id";
                con.Execute(sql, new { stylist_id });
            }
        }

        // SUMMARY STYLIST REPORT


        public StylistModel TotalStaff()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalStaff FROM tbl_stylists";

                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }

        public StylistModel TotalActive()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS TotalActive
                            FROM tbl_stylist_schedules 
                            WHERE day_of_week = LOWER(DAYNAME(CURRENT_DATE)) AND is_working = 1;";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }

        public StylistModel TotalInactive()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS TotalInactive
                            FROM tbl_exception_schedules 
                            WHERE date = CURRENT_DATE AND is_available = 0;";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }

        public StylistModel TopPerformer()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT CONCAT(s.firstName, s.lastName) AS StaffName, SUM(p.amount_paid) AS TotalSales
                            FROM tbl_stylists s
                            JOIN tbl_appointment a ON s.stylist_id = a.stylist_id
                            JOIN tbl_payment p ON a.appointment_id = p.appointment_id
                            GROUP BY s.stylist_id
                            ORDER BY TotalSales DESC
                            LIMIT 1;";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }
        public StylistModel TopPerformer(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT CONCAT(s.firstName, s.lastName) AS StaffName, SUM(p.amount_paid) AS TotalSales
                            FROM tbl_stylists s
                            JOIN tbl_appointment a ON s.stylist_id = a.stylist_id
                            JOIN tbl_payment p ON a.appointment_id = p.appointment_id
                            WHERE a.Date BETWEEN @start AND @end
                            GROUP BY s.stylist_id
                            ORDER BY TotalSales DESC
                            LIMIT 1;";
                return con.Query<StylistModel>(sql, new { start = start, end = end }).FirstOrDefault();
            }
        }

        public IEnumerable<StylistModel> StaffList()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            s.stylist_id,
                            CONCAT(s.firstName, ' ', s.lastName) AS StaffName,
                            s.specialists AS Role,
                            COUNT(DISTINCT a.appointment_id) AS Appointments,
                            SUM(p.amount_paid) AS Sales,
                            CASE 
                                WHEN av.is_available = 1 THEN 'Available'
                                WHEN av.is_available = 0 THEN CONCAT('Unavailable: ', av.reason)
                                ELSE 'No Record'
                            END AS Availability
                        FROM tbl_stylists s
                        LEFT JOIN tbl_appointment a ON s.stylist_id = a.stylist_id 
                        LEFT JOIN tbl_payment p ON a.appointment_id = p.appointment_id
                        LEFT JOIN tbl_exception_schedules av ON s.stylist_id = av.stylist_id AND av.date = CURRENT_DATE
                        WHERE s.is_deleted = 0
                        GROUP BY s.stylist_id, s.firstName, s.lastName, s.specialists, s.address, av.is_available, av.reason;";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public IEnumerable<StylistModel> StaffList(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                        s.stylist_id,
                        CONCAT(s.firstName, ' ', s.lastName) AS StaffName,
                        s.specialists AS Role,
                        COUNT(DISTINCT a.appointment_id) AS Appointments,
                        SUM(p.amount_paid) AS Sales,
                        CASE 
                            WHEN av.is_available = 1 THEN 'Available'
                            WHEN av.is_available = 0 THEN CONCAT('Unavailable: ', av.reason)
                            ELSE 'No Record'
                        END AS Availability
                    FROM tbl_stylists s
                    LEFT JOIN tbl_appointment a ON s.stylist_id = a.stylist_id AND a.Date BETWEEN @start AND @end
                    LEFT JOIN tbl_payment p ON a.appointment_id = p.appointment_id
                    LEFT JOIN tbl_exception_schedules av ON s.stylist_id = av.stylist_id AND av.date = CURRENT_DATE
                    WHERE s.is_deleted = 0
                    GROUP BY s.stylist_id, s.firstName, s.lastName, s.specialists, s.address, av.is_available, av.reason;";
                return con.Query<StylistModel>(sql, new { start = start, end = end }).ToList();
            }
        }

        // VALIDATION

        public List<int> AssignedStylist(DateTime date, TimeSpan start, TimeSpan end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT stylist_id FROM tbl_appointment
                    WHERE Date = @date
                    AND (start_time < @end AND end_time > @start )AND stylist_id IS NOT NULL";

                var result = con.Query<int>(sql, new { date, start, end }).ToList();
                return result;
            }
        }


        public bool EmailExists(string email, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_stylists WHERE email = @email AND stylist_id != @id";

                return con.ExecuteScalar<int>(sql, new { email, id }) > 0;
            }
        }
        public bool ContactExists(string contact, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_stylists WHERE contactNumber = @contact AND stylist_id != @id";

                return con.ExecuteScalar<int>(sql, new { contact, id }) > 0;
            }
        }
    }
}