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
                var sql = "SELECT * FROM tbl_specialist";
                return con.Query<SpecialistModel>(sql).ToList();
            }
        }
        public int Create(SpecialistModel model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_specialist (name) VALUES (@name)";
                return con.Execute(sql,model);
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
    }
}
