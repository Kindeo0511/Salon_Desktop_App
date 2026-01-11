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
    public class OwnderEmailRepository
    {
        public OwnerEmaillModel OwnerEmail() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_owner_email";

                return con.QueryFirstOrDefault<OwnerEmaillModel>(sql);
            }
        }

        public int Create(OwnerEmaillModel model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_owner_email (shop_name, email, pass) VALUES(@shop_name, @email, @pass)";

                return con.Execute(sql,model);
            }
        }

        public int Update(OwnerEmaillModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_owner_email  SET shop_name =@shop_name , email=@email, pass =@pass";

                return con.Execute(sql, model);
            }
        }
    }
}
