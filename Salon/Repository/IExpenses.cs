using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IExpenses
    {
        IEnumerable<ExpensesModel> GetExpenses();
        IEnumerable<ExpensesModel> GetExpenses(DateTime startDate, DateTime endDate);

        ExpensesModel GetSummaryExpenses();
        ExpensesModel GetSummaryExpenses(DateTime startDate, DateTime endDate);
        bool UtilityExists(string category);

        void AddExpenses(ExpensesModel expenses);

        void UpdateExpenses(ExpensesModel model);
    }
}
