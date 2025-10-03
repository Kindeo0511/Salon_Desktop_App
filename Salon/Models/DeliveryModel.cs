using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DeliveryModel
    {
        public int delivery_id { get; set; }
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public DateTime date { get; set; }
        public String invoice { get; set; }
        public string received_by { get; set; }
    }
}
