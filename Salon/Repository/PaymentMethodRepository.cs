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
    }
}
