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
        public int product_size_id { get; set; }
        public string product_name { get; set; }
        public string product_type { get; set; }
        public string brand { get; set; }
        public int category_id { get; set; }
        public string categoryName { get; set; }
        public string unit_type { get; set; }
        public decimal? price { get; set; }
        public decimal? cost { get; set; }
        public int quantity { get; set; } = 1;
        public string size_label { get; set; }
        public int content { get; set; }
        public decimal? selling_price { get; set; }
        public decimal cost_price { get; set; }
        public int is_deleted { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string DisplayName
        {
            get { return product_name + " " + size_label; }
        }


        // PRODUCT SIZE LABEL

        // DASHBOARD SUMMARY
        public int TotalProduct { get; set; }

    }
}
