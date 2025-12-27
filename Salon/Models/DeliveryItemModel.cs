using Org.BouncyCastle.Bcpg;
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
        public string invoice { get; set; }
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string product_name { get; set; }
        public int qty_delivered { get; set; }
        public int qty_received { get; set; }
        public int qty_rejected { get; set; }
        public int total_accepted { get; set; }
        public int total_rejected { get; set; }
        public int content { get; set; }
        public int total_qty { get; set; }
        public decimal unit_price { get; set; }
        public decimal total_price { get; set; }
        public DateTime? expiry_date { get; set; }
        public string notes { get; set; }
        public string item_status { get; set; }



        // DELIVERY REPORT

        public int TotalQty { get; set; }
        public int ExpiredQty { get; set; }

        public DateTime DeliveryDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Expiry { get; set; }
        public string ItemNotes { get; set; }



    }
}
