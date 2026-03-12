using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace Salon.Repository
{
    public class StylistScheduleRepository
    {
        public BindingList<StylistScheduleModel> GetAllScheduleById(int stylistId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT w.weekly_id,
                           w.day_of_week,
                           s.stylist_id,
                           s.is_duty
                    FROM tbl_weekly_schedule w
                    LEFT JOIN tbl_stylist_schedules s
                           ON w.weekly_id = s.weekly_id
                          AND s.stylist_id = @stylist_id
                    ORDER BY w.weekly_id;;";

                var result = con.Query<StylistScheduleModel>(sql, new { stylist_id = stylistId }).ToList();
                return new BindingList<StylistScheduleModel>(result);

            }
        }

        public int GetScheduleById(int stylistId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_stylist_schedules WHERE stylist_id = @stylist_id";

                return con.ExecuteScalar<int>(sql, new { stylist_id = stylistId });


            }
        }
        public void SaveOrUpdateSchedule(StylistScheduleModel schedule, int StylistId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stylist_schedules (stylist_id, weekly_id, is_duty)
                    VALUES (@stylist_id, @weekly_id, @is_duty)
                    ON DUPLICATE KEY UPDATE is_duty = VALUES(is_duty);";

                con.Execute(sql, new
                {
                    stylist_id = StylistId,
                    weekly_id = schedule.weekly_id,
                    is_duty = schedule.is_duty
                });
            }
        }
        //public void SaveOrUpdateSchedule(StylistScheduleModel schedule, int StylistId)
        //{
        //    using (var con = Database.GetConnection())
        //    {
        //        var sql = @"INSERT INTO tbl_stylist_schedules (stylist_id, weekly_id, is_duty)
        //            VALUES (@stylist_id, @weekly_id, @is_duty)
        //            ON DUPLICATE KEY UPDATE is_duty = VALUES(is_duty);";

        //        con.Execute(sql, new
        //        {
        //            stylist_id = StylistId,
        //            weekly_id = schedule.weekly_id,
        //            is_duty = schedule.is_duty
        //        });
        //    }
        //}
    }
}
