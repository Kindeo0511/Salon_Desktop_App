using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Salon.Controller
{
    public class TransactionController
    {
        private readonly TransactionRepository repo;
        public TransactionController(TransactionRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<TransactionModel> ShowAllTransactions() 
        {
            return repo.GetTransactions();
        }
        public IEnumerable<TransactionModel> ShowAllTransactions(DateTime start_date, DateTime end_date)
        {
            return repo.GetTransactions(start_date, end_date);
        }


        public TransactionModel GetTotalSales()
        {
            return repo.GetTotalSales();
        }
        public TransactionModel SalesReportSummary(DateTime start_date, DateTime end_date) 
        {
            return repo.GetTotalReportSales(start_date, end_date);
        }
        public TransactionModel SalesReportSummary()
        {
            return repo.GetTotalReportSales();
        }
        public void AddTransaction(TransactionModel transaction) 
        {
            repo.AddTransaction(transaction);
        }
        public void UpdateTransaction(TransactionModel transaction) 
        {
            repo.UpdateTransaction(transaction);
        }

        public void DeleteTransaction(int id) 
        {
            repo.DeleteTransaction(id);
        }
    }
}
