using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InvoiceServicesCart
    {
        public int ServiceCartId { get; set; }
        public int InvoiceId { get; set; }
        public string ItemType { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
        public int DurationMinutes { get; set; }

    }
}
