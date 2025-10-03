using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface ITransaction
    {
        IEnumerable<TransactionModel> GetTransactions();
        IEnumerable<TransactionModel> GetTransactions(DateTime start_date, DateTime end_date);
        TransactionModel GetTotalSales();

        TransactionModel GetTotalReportSales(DateTime start_date, DateTime end_date);
        void AddTransaction(TransactionModel transaction);
        void UpdateTransaction(TransactionModel transaction);
        void DeleteTransaction(int id);
    }
}
