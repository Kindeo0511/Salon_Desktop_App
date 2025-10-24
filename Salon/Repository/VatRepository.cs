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
    public class VatRepository
    {
        public void addTax(VatModel taxModel)
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute(@"
                INSERT INTO tbl_tax (tax)
                VALUES (@tax);", taxModel);
            }
         
        }
        public void updateTax(VatModel taxModel)
        {
            using (var con = Database.GetConnection()) 
            {

                con.Execute(@"
                UPDATE tbl_tax SET tax = @tax WHERE tax_id = @tax_id;", taxModel);
            }
                
        }
        public IEnumerable<VatModel> getTax()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"
                  SELECT * FROM tbl_tax LIMIT 1;";
                return con.Query<VatModel>(sql).ToList();
            }
               

        }
        public async Task<IEnumerable<VatModel>> GetTaxAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                  SELECT * FROM tbl_tax LIMIT 1;";
                var result = await con.QueryAsync<VatModel>(sql);

                return result.ToList();
            }
        }
        public int checkTax()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT COUNT(*) FROM tbl_tax";
                return con.ExecuteScalar<int>(sql);
            }
               
        }
    }
}
