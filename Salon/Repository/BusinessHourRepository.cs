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
    public class BusinessHourRepository
    {


        public BusinessHour GetHoursForDay(string dayOfWeek)
        {
            using (var con = Database.GetConnection()) 
            {
                var result = con.QueryFirstOrDefault<(TimeSpan Open, TimeSpan Close)>(
                        @"SELECT open_time AS Open, close_time AS Close 
              FROM tbl_business_hours 
              WHERE day_of_week = @Day", new { Day = dayOfWeek });

                return new BusinessHour(dayOfWeek, result.Open, result.Close);
            }

                
        }

    }
}
