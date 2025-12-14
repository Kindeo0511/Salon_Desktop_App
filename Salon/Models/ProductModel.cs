using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ProductModel
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_type { get; set; }
        public string brand { get; set; }
        public int category_id { get; set; }
        public string categoryName { get; set; }
        public string unit_type { get; set; }
        public string usage_type { get; set; }
        public int unit_volume { get; set; }
        public decimal? price { get; set; }

        // DASHBOARD SUMMARY
        public int TotalProduct { get; set; }

    }
}
