using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DiscountUsageModel
    {
        public int usage_id { get; set; }
        public int discount_id { get; set; }
        public int customer_id { get; set; }
        public int appointment_id { get; set; }
        public DateTime used_on { get; set; }
    }
}
