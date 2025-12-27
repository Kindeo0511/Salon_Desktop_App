using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class TransactionDetailsModel
    {
        public int detail_id { get; set; }
        public int transaction_id { get; set; }
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public int qty_delivered { get; set; }
        public int qty_accepted { get; set; }
        public int qty_rejected { get; set; }
        public int qty_remaining { get; set; }
        public int total_remaining { get; set; }
        public decimal unit_price { get; set; }
        public decimal total { get; set; }
        public string DetailStatus { get; set; }
    }
}
