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
        public int AppointmentID { get; set; }
        public int? CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal VATAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
