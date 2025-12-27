using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class StockOutModel
    {
        public int transaction_id { get; set; }
        public int product_size_id { get; set; }
        public string product_name { get; set; }
        public string size_label { get; set; }
        public int qty_delivered { get; set; }
        public int qty_accepted { get; set; }
        public int qty_rejected { get; set; }
        public decimal qty_remaining { get; set; }
        public decimal total_remaining { get; set; }
        public decimal unit_price { get; set; }
        public decimal total { get; set; }
        public DateTime expiry_date { get; set; }

    }
}
