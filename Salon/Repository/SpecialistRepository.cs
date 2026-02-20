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
    public class SpecialistRepository
    {
        public IEnumerable<SpecialistModel> DisplayList()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_specialist WHERE is_deleted = 0";
                return con.Query<SpecialistModel>(sql).ToList();
            }
        }
        public int Create(SpecialistModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_specialist (name) VALUES (@name)";
                return con.Execute(sql, model);
            }
        }

        public int Update(SpecialistModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_specialist SET name = @name WHERE specialist_id = @specialist_id";
                return con.Execute(sql, model);
            }
        }
        public bool Delete(int specialist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_specialist SET is_deleted = 1 WHERE specialist_id = @specialist_id";
                var affectedRows = con.Execute(sql, new { specialist_id });
                return affectedRows > 0;
            }
        }
        public bool PermanentDelete(int specialist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_specialist WHERE specialist_id = @specialist_id";
                var affectedRows = con.Execute(sql, new { specialist_id });
                return affectedRows > 0;
            }
        }
        public bool Restore(int specialist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_specialist SET is_deleted = 0 WHERE specialist_id = @specialist_id";
                var affectedRows = con.Execute(sql, new { specialist_id });
                return affectedRows > 0;
            }
        }
        public bool IsSpecialistIsUsed(int specialist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE 
         WHEN EXISTS (
              SELECT 1 
              FROM tbl_stylist_specialists s
              WHERE s.specialist_id = @specialist_id
         )
         THEN 1 ELSE 0 
       END;";
                return con.ExecuteScalar<int>(sql, new { specialist_id }) == 1;
            }
        }

        public bool SpecialistExists(string name, int specialist_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_specialist WHERE name = @name AND specialist_id != @specialist_id AND is_deleted = 0";
                int count = con.ExecuteScalar<int>(sql, new {name, specialist_id });
                return count > 0;
            }
        }
    }
}
