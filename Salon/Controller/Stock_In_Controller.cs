using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class Stock_In_Controller
    {
        private readonly Stock_In_Repository _repo;

        public Stock_In_Controller(Stock_In_Repository repo) 
        {
            this._repo = repo;
        }

        public IEnumerable<Stock_In_Model> GetAll() 
        {
            return _repo.Stock_In_List();
        }
        public bool AddStock(Stock_In_Model model) 
        {
            return _repo.Add(model) > 0;
        }
        public decimal GetTotalRemaining(int inventory_id) 
        {
            return _repo.GetTotalRemaining(inventory_id);
        }
        public void AddStockIn(Stock_In_Model model, decimal prevTotalRemaining, decimal newTotalRemaining, decimal prevQty, decimal newQty, bool is_update) 
        {
            _repo.AddStockIn(model, prevTotalRemaining, newTotalRemaining, prevQty, newQty, is_update);
        }
    }
}
