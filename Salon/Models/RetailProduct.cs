using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class RetailProduct
    {
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public string product_name { get; set; }
        public string size_label { get; set; }
        public string brand { get; set; }
        public int content { get; set; }
        public decimal selling_price { get; set; }
        public int? quantity { get; set; }
    }
}
