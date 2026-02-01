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
    public class Stylist_Specialist_Repository
    {

        public IEnumerable<Stylist_Specialist_Model> StylistId(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT * FROM tbl_stylist_specialists WHERE stylist_id = @id";
                return con.Query<Stylist_Specialist_Model>(sql, new { id }).ToList();
            }
        }
        public void Create(Stylist_Specialist_Model model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_stylist_specialists (specialist_id, stylist_id) VALUES (@specialist_id, @stylist_id)";
                con.Execute(sql,model);  
            }
        }
        public void Update(Stylist_Specialist_Model model)
        {
            using (var con = Database.GetConnection())
            {
                con.Open(); // 🔑 ensure connection is open

                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        var sql = @"
                            DELETE FROM tbl_stylist_specialists WHERE stylist_id = @stylist_id;
                            INSERT INTO tbl_stylist_specialists (specialist_id, stylist_id) VALUES (@specialist_id, @stylist_id);
                        ";

                        con.Execute(sql, model, tran);

                        tran.Commit();   // ✅ make changes permanent
                    }
                    catch
                    {
                        tran.Rollback(); // ❌ undo everything if something fails
                        throw;
                    }
                }
            }
        }




    }
}
