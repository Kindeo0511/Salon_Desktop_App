using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServiceProductUsageModel
    {
        public int service_product_id { get; set; }
        public int service_id { get; set; }
        public string brand { get; set; }
        public int product_id { get; set; }
        public string serviceName { get; set; }
        public string product_name { get; set; }
        public double unit_per_volume { get; set; }

        public double total_usage_amount { get; set; }
        public int qty_required { get; set; }
        public string usage_type { get; set; }

        public decimal total_cost { get; set; }
        public int duration { get; set; }
        public int is_deleted { get; set; }


    }
}
