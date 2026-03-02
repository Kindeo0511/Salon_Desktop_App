using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class Stock_Out_Model
    {
        public string invoice_number {  get; set; }
        public string product_name {get;set;}
        public string size_label { get; set; }
        public decimal qty { get; set; }
        public decimal qty_volume{ get; set; }
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
        public DateTime created_at { get; set; }

        public string fullName => $"{first_name}, {last_name}";
       
    }
}
