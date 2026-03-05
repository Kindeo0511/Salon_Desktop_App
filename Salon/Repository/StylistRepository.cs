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
                var sql = "SELECT * FROM tbl_stylists WHERE is_deleted = 0";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public int GetSSId(int stylist_id, int service_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT ss_id FROM tbl_stylist_services WHERE stylist_id = @stylist_id AND service_id = @service_id";
                return con.QuerySingleOrDefault<int>(sql, new { stylist_id, service_id });
            }
        }
        public IEnumerable<StylistModel> GetStylistSpecialist() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT DISTINCT 
    
    sp.stylist_id,
    CONCAT(s.firstName, ' ', s.lastName) AS StylistName,
    ts.name AS StylistSpecialty
FROM tbl_stylist_specialists sp
LEFT JOIN tbl_stylists s ON s.stylist_id = sp.stylist_id
LEFT JOIN tbl_specialist ts ON ts.specialist_id = sp.specialist_id
WHERE s.is_deleted = 0;  ";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public IEnumerable<StylistModel> StylistId(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_stylist_services WHERE stylist_id = @id";
                return con.Query<StylistModel>(sql, new { id }).ToList();
            }
        }
        public IEnumerable<StylistModel> GetStylistsByServiceId(int serviceId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_stylist_services WHERE service_id = @serviceId";
                return con.Query<StylistModel>(sql, new { serviceId }).ToList();
            }
        }
        public async Task<IEnumerable<StylistModel>> GetAllStylistAsync(int PageSize, int Offset) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_stylists WHERE is_deleted = 0 LIMIT @PageSize OFFSET @OffSet";
                var result =  await con.QueryAsync<StylistModel>(sql, new { PageSize, Offset});
                return result.ToList();
            }
        }
        public IEnumerable<StylistModel> LoadStylistBasedOnService(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT ss.stylist_id AS StylistId, s.firstName AS firstName, s.lastName AS lastName FROM `tbl_stylist_services` ss
                            JOIN tbl_stylists s ON s.stylist_id = ss.stylist_id
                            WHERE ss.service_id = @id;";

                return con.Query<StylistModel>(sql, new { id }).ToList();
            }
        }
        public IEnumerable<StylistModel> GetStylistWithFullName()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT stylist_id, CONCAT(firstName,' ',middleName,' ',lastName) as fullName FROM tbl_stylists WHERE is_deleted = 0";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public IEnumerable<StylistModel> GetStylistSpecialist(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                        SELECT ss_id, ss.stylist_id, s.firstName, s.middleName, s.lastName
FROM tbl_stylist_services ss
LEFT JOIN tbl_stylists s ON s.stylist_id = ss.stylist_id
LEFT JOIN tbl_servicesname sn ON sn.serviceName_id = ss.service_id
LEFT JOIN tbl_stylist_schedules sc ON sc.stylist_id = s.stylist_id
LEFT JOIN tbl_weekly_schedule ws ON ws.weekly_id = sc.weekly_id
WHERE  s.is_deleted = 0 AND ss.service_id = @id AND sc.is_duty = 1 AND LOWER(ws.day_of_week) = LOWER(DAYNAME(CURDATE()));";
                return con.Query<StylistModel>(sql, new { id }).ToList();
            }
        }
        public StylistModel GetStylistCost()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT ROUND(AVG(daily_wage), 0) AS stylist_cost
                            FROM tbl_stylists WHERE is_deleted = 0;
                            ";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }
        public int AddStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stylists (firstName, middleName, lastName, birth_date, contactNumber, email, address) 
                            VALUES (@firstName, @middleName, @lastName, @birth_date, @contactNumber, @email, @address);
                            SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, stylist);
            }
        }
        public bool AssignService(int stylist_id, int service_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stylist_services (stylist_id, service_id) VALUES (@stylist_id, @service_id)";
                try
                {
                    con.Execute(sql, new { stylist_id, service_id });
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool UnassignService(int stylist_id, int service_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_stylist_services WHERE stylist_id = @stylist_id AND service_id = @service_id;";
                try
                {
                    con.Execute(sql, new {stylist_id, service_id });
                    return true;
                }
                catch (Exception ex)
                {
            
                    return false;
                }
            }
        }
        public bool UpdateAssignService(int ss_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"DELETE FROM tbl_stylist_services WHERE ss_id = @ss_id;";
                try
                {
                    con.Execute(sql, new { ss_id });
                    return true;
                }
                catch (Exception ex)
                {
             
                    return false;
                }
            }

        }
        public int UpdateStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_stylists SET firstName = @firstName, middleName = @middleName, lastName = @lastName, 
                            birth_date = @birth_date, contactNumber = @contactNumber, email = @email, address = @address
                            WHERE stylist_id = @stylist_id";
                return con.Execute(sql, stylist);
            }
        }
        public bool UpdateStylistDuty(int id, bool duty_value)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_stylists SET is_duty = @duty_value WHERE stylist_id = @id";
                return con.Execute(sql, new { id, duty_value}) > 0;
            }
        }
        public int DeleteStylist(int stylist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_stylists SET status = 'Inactive', is_deleted = 1 WHERE stylist_id = @stylist_id";
               return con.Execute(sql, new { stylist_id });
            }
        }
        public int ActivateStylist(int stylist_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_stylists SET status = 'Active', is_deleted = 0 WHERE stylist_id = @stylist_id";
                return con.Execute(sql, new { stylist_id });
            }
        }
        public int PermanentDelete(int stylist_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_stylists WHERE stylist_id = @stylist_id";
                return con.Execute(sql, new { stylist_id });
            }
        }

        public bool IsStylistUsed(int stylist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_appointment_services WHERE stylist_id = @stylist_id ";
                return con.ExecuteScalar<int>(sql, new { stylist_id }) > 0;
            }
        }
        public int GetEmail(string email)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT stylist_id FROM tbl_stylists WHERE email = @email AND is_deleted = 1 LIMIT 1";
                return con.QueryFirstOrDefault<int>(sql, new { email });
            }
        }

        // SUMMARY STYLIST REPORT


        public StylistModel TotalStaff()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalStaff FROM tbl_stylists ";

                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }

        public StylistModel TotalActive()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) AS TotalActive
                            FROM tbl_stylist_schedules 
                            WHERE day_of_week = LOWER(DAYNAME(CURRENT_DATE)) AND is_deleted = 0;";
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
                var sql = "SELECT COUNT(*) FROM tbl_stylists WHERE email = @email AND stylist_id != @id AND is_deleted = 0";

                return con.ExecuteScalar<int>(sql, new { email, id }) > 0;
            }
        }
        public bool ContactExists(string contact, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_stylists WHERE contactNumber = @contact AND stylist_id != @id AND is_deleted = 0";

                return con.ExecuteScalar<int>(sql, new { contact, id }) > 0;
            }
        }

        public List<int> GetAssignedStylistIds(DateTime date, TimeSpan start, TimeSpan end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT stylist_id 
                        FROM tbl_appointments 
                        WHERE appointment_date = @date 
                          AND start_time < @end 
                          AND end_time > @start 
                          AND is_deleted = 0";

                return con.Query<int>(sql, new { date, start, end }).ToList();
            }
        }
    }
}