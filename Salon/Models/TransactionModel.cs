using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class TransactionModel
    {
        public int transaction_id { get; set; }
        public int appointment_id { get; set; }
        public string ClientName { get; set; }
        public string Services { get; set; }
        public string StaffName { get; set; }
        public string payment_method { get; set; }
        public decimal sub_total { get; set; }
        public decimal discount_amount { get; set; }
        public decimal vat_amount { get; set; }
        public decimal amount_paid { get; set; }
        public string payment_status { get; set; }
        public string AppointmentStatus { get; set; }
        public DateTime timestamp { get; set; }
  




        // SUMMARY

        public decimal TotalSales { get; set; }
        
        // REPORTS
        public int total_sales { get; set; }
        public decimal total_vat { get; set; }
        public decimal total_discount { get; set; }
        public int total_transaction { get; set; }
        public decimal cash_total { get; set; }
        public decimal gcash_total { get; set; }


    }
}
