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
    public class UtilityRepository
    {
        public IEnumerable<UtilityModel> AllUtilities() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_utility";
                return con.Query<UtilityModel>(sql).ToList();
            }
        }
        public UtilityModel TotalUtility() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) AS total_util FROM tbl_utility";

                return con.Query<UtilityModel>(sql).FirstOrDefault();
            }
        }
        public void AddUtility(UtilityModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_utility (util_name, util_text) VALUES (@util_name, @util_text)";
                con.Execute(sql, model);
            }
        }
        public void UpdateUtility(UtilityModel model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_utility SET util_name=@util_name, util_text=@util_text WHERE util_id = @util_id";
                con.Execute(sql,model);
            }
        }
        public void RemoveUtility(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "DELETE FROM tbl_utility WHERE util_id = @util_id";
                con.Execute(sql, new { util_id = id});
            }
        }
    }
}
