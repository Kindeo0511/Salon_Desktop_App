using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class Stock_In_Model
    {
        public int stock_in_id { get; set; }
        public int delivery_id { get; set; }
        public int product_id { get; set; }
        public string product_type { get; set; }
        public string supplier_name { get; set; }
        public string product_name { get; set; }
        public int product_size_id { get; set; }
        public string size_label { get; set; }
      
        public int qty { get; set; }
        public int qty_remaining  => qty;
        public int total { get; set; }
        public int total_remaining  => total;
        public DateTime created_at { get; set; }


    }
}
