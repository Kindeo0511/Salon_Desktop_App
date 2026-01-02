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
    public class PaymentMethodRepository : I_PaymentMethod
    {
        public IEnumerable<PaymentMethodModel> GetPaymentMethod()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_payment_method;";
                var result = con.Query<PaymentMethodModel>(sql).ToList();
                return result;
            }
        }
        public int Add(PaymentMethodModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_payment_method (name, required_reference, is_active, created_at)
                            VALUES (@name, @required_reference, @is_active, CURRENT_TIMESTAMP())";
                return con.Execute(sql,  model);
            }
        }
        public int Update(PaymentMethodModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_payment_method
                    SET name = @name,
                        required_reference = @required_reference,
                        is_active = @is_active,
                        updated_at = CURRENT_TIMESTAMP()
                        WHERE id = @id";
                return con.Execute(sql, model);
            }
        }
        public int SoftDelete(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_payment_method SET is_deleted = 1 WHERE id = @id";
                return con.Execute(sql, new { id });
            }
        }

        public int HardDelete(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"DELETE tbl_payment_method WHERE id = @id";
                return con.Execute(sql, new { id });
            }
        }
    }
}
