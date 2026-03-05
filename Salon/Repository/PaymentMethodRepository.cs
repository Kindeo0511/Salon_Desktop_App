using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.Repository
{
    public class PaymentMethodRepository : I_PaymentMethod
    {
    
        public IEnumerable<PaymentMethodModel> GetPaymentMethod()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_payment_method WHERE is_deleted = 0;";
                var result =  con.Query<PaymentMethodModel>(sql);
                return result.ToList();
            }
        }
        public int Add(PaymentMethodModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_payment_method (name, required_reference, created_at)
                            VALUES (@name, @required_reference, CURRENT_TIMESTAMP())";
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
        public bool RestorePaymentMethood(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_payment_method SET is_deleted = 0 WHERE id = @id";
                return con.Execute(sql, new { id }) > 0;
            }
        }
        public int GetDeletedPaymentMethodId(string name) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT id FROM tbl_payment_method WHERE is_deleted = 1 AND name = @name;";
                int result = con.QueryFirstOrDefault<int>(sql, new { name });
                return result;
            }
        }

        public bool IsPaymentMethodAlreadyExists(string name, int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_payment_method WHERE is_deleted = 0 AND name = @name AND id != @id;";
                var result = con.ExecuteScalar<int>(sql, new { name , id});
                return result > 0;
            }
        }
    }
}
