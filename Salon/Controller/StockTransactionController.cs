using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class StockTransactionController
    {
        private readonly StockTransactionRepository repo;

        public StockTransactionController(StockTransactionRepository repository)
        {
            this.repo = repository;
        }


        public int AddStockTransaction(StockTransactionModel model)
        {
            return repo.AddStockTransaction(model);
        }
    }
}
