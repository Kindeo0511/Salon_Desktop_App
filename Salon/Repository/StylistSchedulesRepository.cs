using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace Salon.Repository
{
    public class StylistSchedulesRepository : IStylistSchedules
    {

        public IEnumerable<StylistScheduleModel> GetStylistSchedules(int stylistId)
        {

            using (var connection = Database.GetConnection()) 
            {
                return connection.Query<StylistScheduleModel>("SELECT id as ScheduleId, stylist_id as StylistId, day_of_week as DayOfWeek, start_time as StartTime, end_time as EndTime, is_working as IsWorking FROM tbl_stylist_schedules WHERE stylist_id =@StylistId AND is_deleted = 0", new { StylistId = stylistId }).ToList();
            }
            
        }
        public void AddStylistSchedule(StylistScheduleModel stylistSchedules)
        {
            using (var connection = Database.GetConnection()) 
            {
                connection.Execute("INSERT INTO tbl_stylist_schedules (stylist_id, day_of_week, start_time, end_time, is_working) VALUES (@StylistId, @DayOfWeek, @StartTime, @EndTime, @IsWorking)", stylistSchedules);
            }
            
        }
        public void UpdateStylistSchedule(StylistScheduleModel stylistSchedules)
        {
            using (var connection = Database.GetConnection()) 
            {
                connection.Execute("UPDATE tbl_stylist_schedules SET stylist_id = @StylistId, day_of_week = @DayOfWeek, start_time = @StartTime, end_time = @EndTime, is_working = @IsWorking WHERE id = @ScheduleId", stylistSchedules);
            }
                
        }
        public void DeleteStylistSchedule(int scheduleId)
        {
            using (var connection = Database.GetConnection()) 
            {
                connection.Execute("UPDATE tbl_stylist_schedules SET is_deleted = 1 WHERE id = @Id", new { Id = scheduleId });
            }
                
        }
        public void PermanentDelete(int scheduleId) 
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("DELETE FROM tbl_stylist_schedules WHERE id = @Id", new { Id = scheduleId });
            }
        }
        public void RestoreStylistSchedule(int scheduleId) 
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("UPDATE tbl_stylist_schedules SET is_deleted = 0 WHERE id = @Id", new { Id = scheduleId });
            }
        }

        // VALIDATION

        public List<StylistModel> StylistSchedules(string dayOfWeek) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT s.stylist_id, CONCAT(s.firstName,' ',s.middleName, ' ', s.lastName) AS fullName
                    FROM tbl_stylist_schedules ss
                    JOIN tbl_stylists s ON s.stylist_id = ss.stylist_id
                    WHERE ss.day_of_week = @dayOfWeek AND ss.is_working = 1";

                return con.Query<StylistModel>(sql, new { dayOfWeek }).ToList();

            }
        }

        public bool IsScheduleConflict(int stylist_id, string day, TimeSpan start, TimeSpan end, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) FROM tbl_stylist_schedules
            WHERE stylist_id = @stylist_id AND day_of_week = @day AND id != @id
            AND (
                @start < end_time AND @end > start_time
            )";
                var count = con.ExecuteScalar<int>(sql, new { stylist_id, day, start, end, id });
                return count > 0;


            }
        }
    }
}
