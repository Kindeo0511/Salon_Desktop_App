using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SupplierModel
    {
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public int is_deleted { get; set; }

    }
}
