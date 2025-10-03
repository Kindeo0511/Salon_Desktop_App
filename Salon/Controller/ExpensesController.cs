using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddExpenses(ExpensesModel expenses) 
        {
            repo.AddExpenses(expenses);
        }
    }
}
