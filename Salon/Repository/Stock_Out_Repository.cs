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
    public class Stock_Out_Repository
    {
        public IEnumerable<Stock_Out_Model> Stock_Out_Lists() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM stock_out_details";
                return con.Query<Stock_Out_Model>(sql);
            }
        }
    }
}
