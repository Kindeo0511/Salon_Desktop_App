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
        
        public string supplier_name { get; set; }
        public int product_size_id { get; set; }
      

        public int total { get; set; }
        public int total_remaining  => total;

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

        // STOCK IN DETAILS

        public int refund_id { get; set; }
        public int stock_out_id { get; set; }
        public int inventory_id { get; set; }
        public string product_name { get; set; }
        public string brand { get; set; }
        public string size_label { get; set; }
        public decimal qty { get; set; }
        public decimal qty_volume { get; set; }
        public decimal unit_price { get; set; }
        public decimal line_total { get; set; }
        public decimal previous_total_remaining { get; set; }
        public decimal new_total_remaining { get; set; }
        public decimal previous_qty { get; set; }
        public decimal new_qty { get; set; }
        public string movement_type { get; set; }
        public string reason { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string fullName => $"{first_name}, {last_name}";
        public int created_by { get; set; }
        public DateTime created_at { get; set; }


    }
}
