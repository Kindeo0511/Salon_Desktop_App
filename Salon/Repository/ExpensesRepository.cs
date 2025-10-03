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
    public class ExpensesRepository : IExpenses
    {
        public IEnumerable<ExpensesModel> GetExpenses() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_expenses";
                return con.Query<ExpensesModel>(sql).ToList();
            }
        }

        public void AddExpenses(ExpensesModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_expenses (category, description, amount, paid_by, notes, timestamp) VALUES (@category, @description, @amount, @paid_by, @notes, @timestamp)";
                con.Execute(sql, model);
            }
        }
    }
}
