using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class Stock_Out_Model
    {
        public string product_name {get;set;}
        public string product_type {get;set;}
        public string brand { get; set; }
        public string product_unit_type { get; set; }
        public int qty_delivered { get; set; }
        public int total_qty_delivered{ get; set; }
        public decimal qty_remaining { get; set; }
        public decimal total_qty_remaining { get; set; }
        public decimal quantity { get; set; }
        public decimal total { get; set; }
        public string unit_type { get; set; }
        public string out_type { get; set; }
        public DateTime created_at { get; set; }
    }
}
