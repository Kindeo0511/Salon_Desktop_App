using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Salon.Controller
{
    public  class ExpensesController
    {
        private readonly ExpensesRepository repo;

        public ExpensesController(ExpensesRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<ExpensesModel> GetAllExpenses() 
        {
            return repo.GetExpenses();
        }
        public IEnumerable<ExpensesModel> GetAllExpenses(DateTime startDate, DateTime endDate)
        {
            return repo.GetExpenses(startDate, endDate);
        }

        public ExpensesModel GetSummaryExpenses() 
        {
            return repo.GetSummaryExpenses();
        }
        public ExpensesModel GetSummaryExpenses(DateTime startDate, DateTime endDate)
        {
            return repo.GetSummaryExpenses(startDate, endDate);
        }

        public bool Is_UtilityExists(string category) 
        {
            return repo.UtilityExists(category);
        }
        public void AddExpenses(ExpensesModel expenses) 
        {
            repo.AddExpenses(expenses);
        }

        public void UpdateExpense(ExpensesModel expenses) 
        {
            repo.UpdateExpenses(expenses);
        }
    }
}
