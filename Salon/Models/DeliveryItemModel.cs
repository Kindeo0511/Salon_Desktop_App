using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DeliveryItemModel
    {
        public int delivery_item_id { get; set; }
        public int delivery_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int qty { get; set; }
        public decimal unit_price { get; set; }
        public decimal total_price { get; set; }
        public DateTime? expiry_date { get; set; }
        public string notes { get; set; }







    }
}
