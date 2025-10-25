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
    public class ExceptionSchedulesRepository : IExceptionSchedules
    {

        public IEnumerable<ExceptionScheduleModel> GetExceptionSchedules(int stylist_id)
        {
            using (var connection = Database.GetConnection()) 
            {
                return connection.Query<ExceptionScheduleModel>("SELECT * FROM tbl_exception_schedules WHERE stylist_id = @StylistId AND is_deleted = 0", new { StylistId = stylist_id }).ToList();
            }
               
        }
        public void AddExceptionSchedule(ExceptionScheduleModel exceptionSchedule)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("INSERT INTO tbl_exception_schedules (stylist_id, date, is_available, reason) VALUES (@stylist_id, @date, @is_available, @reason)", exceptionSchedule);


            }
        }
        public void UpdateExceptionSchedule(ExceptionScheduleModel exceptionSchedule)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("UPDATE tbl_exception_schedules SET stylist_id = @stylist_id, date = @date, is_available = @is_available, reason = @reason WHERE id = @id", exceptionSchedule);
            }
        }
        public void DeleteExceptionSchedule(int exceptionScheduleId)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("UPDATE tbl_exception_schedules SET is_deleted = 1 WHERE id = @Id", new { Id = exceptionScheduleId });
            }
        }

        public void RestoreExceptionSchedule(int exceptionScheduleId) 
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("UPDATE tbl_exception_schedules SET is_deleted = 0 WHERE id = @Id", new { Id = exceptionScheduleId });
            }
        }
        public void PermanentDelete(int exceptionScheduleId) 
        {
            using (var connection = Database.GetConnection())
            {
                connection.Execute("DELETE FROM tbl_exception_schedules  WHERE id = @Id", new { Id = exceptionScheduleId });
            }
        }

        // VALIDATION

        public bool CheckExceptionSchedule(DateTime date) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM `tbl_exception_schedules` WHERE date = @date AND is_available = 1";
                int result = con.ExecuteScalar<int>(sql,new { date });

                return result > 0;
            }
        }
        public bool IsExceptionScheduleConflict(int stylist_id, DateTime date, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) 
                    FROM tbl_exception_schedules
                    WHERE stylist_id = @stylist_id
                      AND DATE(date) = DATE(@date)
                      AND id != @id
                      AND is_deleted = 0;";

                var count = con.ExecuteScalar<int>(sql, new { stylist_id, date = date.Date, id });
                return count > 0;
            }
        }

        public List<int> GetUnavailableStylistIds(DateTime date)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT stylist_id 
                    FROM tbl_exception_schedules 
                    WHERE date = @date AND is_available = 0 AND is_deleted = 0";

                return con.Query<int>(sql, new { date }).ToList();
            }
        }


    }
}
