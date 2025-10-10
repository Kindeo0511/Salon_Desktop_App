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
        public int transaction_id { get; set; }
        public int appointment_id { get; set; }
        public string Service_Name { get; set; }
        public decimal Original_Price { get; set; }
        public decimal refund_amount { get; set; }
        public string refund_method { get; set; }
        public string refund_reason { get; set; }
        public string refunded_by { get; set; }
        public DateTime refund_timestamp { get; set; }
        public string status { get; set; }


        public string Services { get; set; }
        public decimal selling_price { get; set; }


      


    }
}
