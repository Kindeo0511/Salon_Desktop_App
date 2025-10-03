using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServicePriceModel
    {
        public int pricing_id { get; set; }
        public string serviceName { get; set; }
        public int service_product_id { get; set; }
        public decimal product_cost { get; set; }
        public decimal stylist_cost { get; set; }
        public decimal overhead_cost { get; set; }
        public decimal total_cost { get; set; }
        public decimal selling_price { get; set; }
        public decimal vat_amount { get; set; }
        public decimal net_price { get; set; }
        public decimal net_profit { get; set; }
        public decimal gross_profit { get; set; }
        public decimal profit_percent { get; set; }
    }
}
