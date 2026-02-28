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
        public int is_retail { get; set; }
        public int is_ingredient { get; set; }

        public string DisplayProductType
        {
            get
            {
                if (is_ingredient == 1 && is_retail == 1)
                {
                    return "Ingredient/Retail";
                }
                else if (is_ingredient == 1)
                {
                    return "Ingredient";
                }
                else if (is_retail == 1)
                {
                    return "Retail";
                }
                else
                {
                    return "None"; // or whatever default makes sense
                }
            }
        }

        public string Ingredient
        {
            get
            {
                return is_ingredient == 1 ? "Ingredient" : string.Empty;
            }
        }
        public string retail 
        {
            get 
            {
                return is_retail == 1 ? "Retail" : string.Empty ;
            }
        }
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
