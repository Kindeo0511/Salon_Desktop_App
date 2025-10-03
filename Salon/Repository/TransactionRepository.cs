using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class TransactionRepository
    {
        public IEnumerable<TransactionModel> GetTransactions() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_transaction";

                return con.Query<TransactionModel>(sql).ToList();
            }
        }

        public IEnumerable<TransactionModel> GetTransactions(DateTime start_date, DateTime end_date)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_transaction WHERE timestamp BETWEEN @start_date AND @end_date";

                return con.Query<TransactionModel>(sql, new { start_date = start_date, end_date = end_date}).ToList();
            }
        }

        public TransactionModel GetTotalSales() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT SUM(amount_paid) AS TotalSales FROM tbl_transaction WHERE payment_status = 'paid';";
                
                return con.Query<TransactionModel>(sql).FirstOrDefault();
            }
        }
        public TransactionModel GetTotalReportSales() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                            SUM(amount_paid) AS total_sales,
                            SUM(vat_amount) AS total_vat,
                            SUM(discount_amount) AS total_discount,
                            COUNT(*) AS total_transaction,
                            SUM(CASE WHEN payment_method = 'Cash' THEN amount_paid ELSE 0 END) AS cash_total,
                            SUM(CASE WHEN payment_method = 'GCash' THEN amount_paid ELSE 0 END) AS gcash_total
                        FROM tbl_transaction;
                        ";
                return con.Query<TransactionModel>(sql).FirstOrDefault();
            }
        }
        public TransactionModel GetTotalReportSales(DateTime start_date , DateTime end_date)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            SUM(amount_paid) AS total_sales,
                            SUM(vat_amount) AS total_vat,
                            SUM(discount_amount) AS total_discount,
                            COUNT(*) AS total_transaction,
                            SUM(CASE WHEN payment_method = 'Cash' THEN amount_paid ELSE 0 END) AS cash_total,
                            SUM(CASE WHEN payment_method = 'GCash' THEN amount_paid ELSE 0 END) AS gcash_total
                        FROM tbl_transaction
                            WHERE timestamp BETWEEN @start_date AND @end_date;
                        ";
                return con.Query<TransactionModel>(sql, new { start_date = start_date, end_date = end_date}).FirstOrDefault();
            }
        }
        public void AddTransaction(TransactionModel transaction) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_transaction (appointment_id, vat_amount, discount_amount, amount_paid, payment_method, payment_status, timestamp)
                            VALUES (@appointment_id, @vat_amount, @discount_amount, @amount_paid, @payment_method, @payment_status, @timestamp)";

                con.Execute(sql,transaction);
            }
        }
        public void UpdateTransaction(TransactionModel transaction) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_transaction
                        SET appointment_id = @appointment_id,
                        vat_amount = @vat_amount,
                        discount_amount = @discount_amount,
                        amount_paid = @amount_paid,
                        payment_method = @payment_method,
                        payment_status = @payment_status,
                        timestamp = @timestamp ";
                con.Execute(sql,transaction);
            }
        }
        public void DeleteTransaction(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "DELETE FROM tbl_transaction WHERE transaction_id = @transaction_id";
                con.Execute(sql, new { transaction_id = id});
            }
        }
    }
}
