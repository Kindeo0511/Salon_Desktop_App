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
        public IEnumerable<ExpensesModel> GetExpenses(DateTime startDate, DateTime endDate)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_expenses WHERE timestamp BETWEEN @startDate AND @endDate";
                return con.Query<ExpensesModel>(sql, new { startDate = startDate, endDate = endDate}).ToList();
            }
        }

        public ExpensesModel GetSummaryExpenses() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT
                            SUM(amount) AS TotalExpense,
                            SUM(CASE WHEN category = 'Inventory Purchase' THEN amount ELSE 0 END) AS TotalPurchaseInventory,
                            SUM(CASE WHEN category = 'Utilities' THEN amount ELSE 0 END) AS TotalUtilities,
                            SUM(CASE WHEN category = 'Supplies' THEN amount ELSE 0 END) AS TotalSupplies
                            FROM tbl_expenses ";
                return con.Query<ExpensesModel>(sql).FirstOrDefault();
            }
        }
        public ExpensesModel GetSummaryExpenses(DateTime startDate, DateTime endDate) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT
                            SUM(amount) AS TotalExpense,
                            SUM(CASE WHEN category = 'Inventory Purchase' THEN amount ELSE 0 END) AS TotalPurchaseInventory,
                            SUM(CASE WHEN category = 'Utilities' THEN amount ELSE 0 END) AS TotalUtilities,
                            SUM(CASE WHEN category = 'Supplies' THEN amount ELSE 0 END) AS TotalSupplies
                            FROM tbl_expenses WHERE timestamp BETWEEN @startDate AND @endDate";
                return con.Query<ExpensesModel>(sql, new { startDate = startDate, endDate = endDate}).FirstOrDefault();
            }
        }
        public bool UtilityExists(string category) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_expenses WHERE category = @category";
                return con.ExecuteScalar<int>(sql, new { category = category }) > 0 ;
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

        public void UpdateExpenses(ExpensesModel model)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_expenses SET category = @category, description = @description, amount = @amount, paid_by = @paid_by, notes = @notes, timestamp = @timestamp WHERE category = @category";
                con.Execute(sql, model);
            }
        }
    }
}
