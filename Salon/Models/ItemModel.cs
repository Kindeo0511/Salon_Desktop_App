using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ItemModel
    {
        public int item_id { get; set; }
        public string name { get; set; }
        public string item_type { get; set; }
        public decimal price { get; set; }
    }
}
