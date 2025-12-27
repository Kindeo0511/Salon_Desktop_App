using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class TransactionDetailController
    {
        private readonly TransactionDetailsRepository repo;
        public TransactionDetailController(TransactionDetailsRepository repo) 
        {
            this.repo = repo;
        }

        public void AddTransactionDetail(TransactionDetailsModel model) 
        {
            repo.AddTransactionDetails(model);
        }

        public IEnumerable<TransactionDetailsModel> GetTransactionsDetailByProductId(int transaction_id, int product_id)
        {
            return repo.GetTransactionDetailsByProductId(transaction_id,product_id);
        }
    }
}
