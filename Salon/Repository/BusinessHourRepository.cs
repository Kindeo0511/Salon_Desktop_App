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

        public BusinessHour GetOpenHour() 
        {
            using (var con = Database.GetConnection()) 
            {

                var sql = @"SELECT * FROM tbl_business_hours";

                return con.QueryFirstOrDefault<BusinessHour>(sql);

            }
        }
       

    }
}
