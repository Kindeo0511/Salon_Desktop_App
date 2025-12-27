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
    public class StockTransactionRepository
    {
        public int AddStockTransaction(StockTransactionModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_stock_transaction 
                            (transaction_type, reference_no, date, supplier_id, user_id, notes, status)
                            VALUES (@transaction_type, @reference_no, @date, @supplier_id, @user_id, @notes, @status); SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, model);
            }
        }
    }
}
