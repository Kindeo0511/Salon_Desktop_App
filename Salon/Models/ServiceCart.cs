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
        public int service_cart_id { get; set; }
        public int InvoiceId { get; set; }
        public string ItemType { get; set; } // "Product" or "Service"
        public string Size { get; set; }
        public int? ProductId { get; set; }
        public int? ProductSizeId { get; set; }
        public int? ServiceId { get; set; }
        public string ItemName { get; set; }
        public int Duration { get; set; } // in minutes
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int RefundQty { get; set; }
        public decimal TotalPrice => Price * Quantity;
        public int Voided { get; set; }
        public int Refunded { get; set; }
        public string Status { get { if (Voided == 1)
                    return "Void"; else if (Refunded == 1)
                    return "Refunded"; else return "Active"; } }

    }
}
    
