using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InvoiceServicesCart
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Quantity * Price;
        public int Voided { get; set; }
        public int Refunded { get; set; }
        public string Status
        {
            get
            {
                if (Voided == 1)
                    return "Void";
                else if (Refunded == 1)
                    return "Refunded";
                else return "Active";
            }
        }

        
    }
}
