using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServiceCart
    {
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }
        public string ItemName { get; set; }
        public int Duration { get; set; } // in minutes
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal TotalPrice => Price * Quantity;
    }
}
