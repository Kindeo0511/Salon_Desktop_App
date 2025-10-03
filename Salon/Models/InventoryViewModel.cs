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
        public string product_name { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public double unit { get; set; }
        public int volume_per_unit { get; set; }
        public int volume { get; set; }
        public int critical_level { get; set; }
        public string status { get; set; }
        public DateTime expiry_date { get; set; }

        // INVENTORY REPORTS
        public int total_products { get; set; }
        public int total_volume { get; set; }
        public int in_stock_items { get; set; }
        public int out_of_stock_items { get; set; }
        public int low_stock_items { get; set; }

    }
}
