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

        public IEnumerable<TransactionModel> GetAllTransactions() 
        {
           return repo.ShowAllTransactions();
        }
        public IEnumerable<TransactionModel> GetAllTransactions(DateTime start, DateTime end)
        {
            return repo.ShowAllTransactions(start, end);
        }

        public async Task<IEnumerable<TransactionModel>> GetAllTransactionsAsync()
        {
            return await repo.ShowAllTransactionAsync();
        }

        public async Task<IEnumerable<TransactionModel>> GetAllTransactionsAsync(DateTime start, DateTime end)
        {
            return await repo.ShowAllTransactionAsync(start, end);
        }

        public IEnumerable<TransactionModel> ShowAllTransactions() 
        {
            return repo.GetTransactions();
        }
        public IEnumerable<TransactionModel> ShowAllTransactions(DateTime start_date, DateTime end_date)
        {
            return repo.GetTransactions(start_date, end_date);
        }

        public async Task<IEnumerable<TransactionModel>> ShowAllTransactionAsync() 
        {
            return await repo.GetTransactionAsync();
        }

        public async Task<IEnumerable<TransactionModel>> ShowAllTransactionAsync(DateTime start_date, DateTime end_date)
        {
            return await repo.GetTransactionAsync(start_date, end_date);
        }

        public TransactionModel GetTotalSales()
        {
            return repo.GetTotalSales();
        }
        public async Task<TransactionModel> GetTotalSalesAsync() 
        {
            return await repo.GetTotalSalesAsync();
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

        public void UpdateTransactionStatus(int id ,string status) 
        {
            repo.UpdateTransactionStatus(id, status);
        }

        public void DeleteTransaction(int id) 
        {
            repo.DeleteTransaction(id);
        }
    }
}
