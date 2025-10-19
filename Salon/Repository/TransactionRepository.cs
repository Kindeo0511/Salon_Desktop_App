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
        public IEnumerable<TransactionModel> ShowAllTransactions() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
							t.transaction_id,
                            a.appointment_id,
                            CONCAT(ca.firstName, ' ', ca.middleName, ' ', ca.lastName) AS ClientName,
                            GROUP_CONCAT(sn.serviceName SEPARATOR ', ') AS Services,
                            CONCAT(s.firstName, ' ', s.lastName) AS StaffName,
                            t.payment_method,
                            t.sub_total,
                            t.discount_amount,
                            t.vat_amount,
                            t.amount_paid,
                            t.payment_status AS AppointmentStatus,
                            t.timestamp
                        FROM tbl_transaction t
                        LEFT JOIN tbl_appointment a ON a.appointment_id = t.appointment_id
                        LEFT JOIN tbl_appointment_services aps ON aps.appointment_id = a.appointment_id
                        LEFT JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
                        LEFT JOIN tbl_customer_account ca ON ca.customer_id = a.customer_id
                        LEFT JOIN tbl_stylists s ON s.stylist_id = a.stylist_id
                        GROUP BY t.transaction_id";
                return con.Query<TransactionModel>(sql).ToList();
            }
        }
        public IEnumerable<TransactionModel> ShowAllTransactions(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                            t.transaction_id,
                            a.appointment_id,
                            CONCAT(ca.firstName, ' ', ca.middleName, ' ', ca.lastName) AS ClientName,
                            GROUP_CONCAT(sn.serviceName SEPARATOR ', ') AS Services,
                            CONCAT(s.firstName, ' ', s.lastName) AS StaffName,
                            t.payment_method,
                            t.sub_total,
                            t.discount_amount,
                            t.vat_amount,
                            t.amount_paid,
                            t.payment_status AS AppointmentStatus,
                            t.timestamp
                        FROM tbl_transaction t
                        LEFT JOIN tbl_appointment a ON a.appointment_id = t.appointment_id
                        LEFT JOIN tbl_appointment_services aps ON aps.appointment_id = a.appointment_id
                        LEFT JOIN tbl_servicesname sn ON sn.serviceName_id = aps.serviceName_id
                        LEFT JOIN tbl_customer_account ca ON ca.customer_id = a.customer_id
                        LEFT JOIN tbl_stylists s ON s.stylist_id = a.stylist_id
                        WHERE t.timestamp BETWEEN @start AND @end
                        GROUP BY t.transaction_id";
                return con.Query<TransactionModel>(sql, new { start, end }).ToList();
            }
        }
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
                var sql = @"INSERT INTO tbl_transaction (appointment_id, vat_amount, discount_amount,sub_total, amount_paid, payment_method, payment_status, timestamp)
                            VALUES (@appointment_id, @vat_amount, @discount_amount, @sub_total, @amount_paid, @payment_method, @payment_status, @timestamp)";

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
                        sub_total = @subtotal,
                        amount_paid = @amount_paid,
                        payment_method = @payment_method,
                        payment_status = @payment_status,
                        timestamp = @timestamp ";
                con.Execute(sql,transaction);
            }
        }
        public void UpdateTransactionStatus(int transaction_id, string status)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_transaction
                    SET payment_status = @status
                    WHERE transaction_id = @transaction_id";

                con.Execute(sql, new { status = status, transaction_id = transaction_id });
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
