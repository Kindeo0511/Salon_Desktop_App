using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class StockOutController
    {
        private readonly StockOutRepository repo;

        public StockOutController(StockOutRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<StockOutModel> GetAllTransactionDetails() 
        {
            return repo.GetAllTransactionDetails();
        }
        public StockOutModel GetTransactionId(int product_id) 
        {
            return repo.GetTransactionId(product_id);
        }
        public void UpdateProductTransaction(int transaction_id, int product_size_id, int qty) 
        {
            repo.UpdateProducTransaction(transaction_id, product_size_id,  qty);
        }

        public void VoidProductTransaction(int transaction_id, int size, int qty) 
        {
            repo.VoidProductTransaction(transaction_id, size, qty);
        }

        public void UpdateTransaction(int transaction_id, int qty) 
        {
            repo.UpdateTransaction(transaction_id, qty);
        }
        public void DeductStockOut(int product_id, int deduction, string out_type, string unit_type) 
        {
            repo.DeductStock(product_id, deduction, out_type, unit_type);
        }

        public void DeductProductStockOut(int product_id, int product_size_id, int deduction, string out_type, string unit_type) 
        {
            repo.DeductProductStock(product_id, product_size_id, deduction, out_type, unit_type);
        }
    }
}
