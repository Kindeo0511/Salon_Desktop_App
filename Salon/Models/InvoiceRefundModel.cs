using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InvoiceRefundModel
    {
        public int refund_id { get; set; }
        public int service_cart_id { get; set; }
        public int refund_qty { get; set; }
        public string reason { get; set; }
        public string refunded_by { get; set; }
        public DateTime refunded_at { get; set; }
    }
}
