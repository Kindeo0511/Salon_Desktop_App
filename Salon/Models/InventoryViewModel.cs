using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InventoryViewModel
    {
        public int inventory_id { get; set; }
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public string product_name { get; set; }
        public string size_label { get; set; }
        public string product_type { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public decimal qty { get; set; }
        public int total_remaining { get; set; }
        public int volume { get; set; }
        public int critical_level { get; set; }
        public string status { get; set; }
        public DateTime expiry_date { get; set; }

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


        // INVENTORY REPORTS
        public int total_products { get; set; }
        public int total_volume { get; set; }
        public int in_stock_items { get; set; }
        public int out_of_stock_items { get; set; }
        public int low_stock_items { get; set; }

    }
}
