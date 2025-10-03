using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class InventoryBatchModel
    {
        public int batch_id { get; set; }
        public int delivery_item_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int unit { get; set; }
        public int volume_per_unit { get; set; }
        public int volume { get; set; }
        public decimal price { get; set; }
        public string notes { get; set; }
        public DateTime delivered_date { get; set; }
        public DateTime expiry_date { get; set; }



    }
}
