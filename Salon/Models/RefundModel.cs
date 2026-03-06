using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class RefundModel
    {
        public int refund_id { get; set; }
        public string product_name { get; set; }
        public string brand { get; set; }
        public string size_label { get; set; }
        public int refund_qty { get; set; }
        public decimal refund_amount { get; set; }
        public string reason { get; set; }
        public string refunded_by { get; set; }
        public DateTime refunded_at { get; set; }


      


    }
}
