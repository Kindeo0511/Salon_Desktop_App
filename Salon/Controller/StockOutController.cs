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
        public void RefundProduct(int stock_in_id, int product_size, int qty) 
        {
             repo.RefundProduct(stock_in_id, product_size, qty);
        }
        public void UpdateProductTransaction(int transaction_id, int product_size_id, int qty) 
        {
            repo.UpdateProducTransaction(transaction_id, product_size_id,  qty);
        }

        public void VoidProductTransaction(int transaction_id, int size, int qty) 
        {
            repo.VoidProductTransaction(transaction_id, size, qty);
        }

        public void UpdateTransaction(int stock_in_id, int qty) 
        {
            repo.UpdateTransaction(stock_in_id, qty);
        }
        public void DeductStockOut(int product_id, int deduction, string out_type, string unit_type) 
        {
            repo.DeductStock(product_id, deduction, out_type, unit_type);
        }
        public void DeductProductConsumables(int product_id, int request_ml, int invoice_id) 
        {
            repo.DeductProductStockConsumables(product_id, request_ml, invoice_id);
        }
        public void DeductProductStockOut(int product_id, int product_size_id, int deduction, string out_type, string unit_type) 
        {
            repo.DeductProductStock(product_id, product_size_id, deduction, out_type, unit_type);
        }

        public void DeductProductRetailStocks(int product_id, int product_size_id, int qty, int invoice_id, decimal price)
        {
            repo.DeductProductRetailStock(product_id, product_size_id, qty, invoice_id, price);
        }
        public void RefundProductRetailStock(int product_id, int product_size_id, decimal qtyBottlesToRefund, int invoice_id, int refund_id, decimal unit_price, string reason) 
        {
            repo.RefundProductRetailStock(product_id, product_size_id, qtyBottlesToRefund, invoice_id, refund_id, unit_price, reason);
        }
    }
}
