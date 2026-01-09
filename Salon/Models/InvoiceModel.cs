using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public string Name { get; set; }
        public int AppointmentID { get; set; }
        public int? CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal VATAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public int payment_method_id { get; set; }
        public string reference_number { get; set; }
        public string Notes { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? Timestamp { get; set; }
        public string status { get; set; }



        // SALES REPORT SUMMARY
        public decimal TotalSales { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal TotalRefund { get; set; }
        public decimal TotalServiceSale { get; set; }
        public decimal TotalProductSale { get; set; }
        public DateTime timestamp { get; set; }

    }
}
