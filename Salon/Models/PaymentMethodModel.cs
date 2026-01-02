using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class PaymentMethodModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public  bool required_reference { get; set; }
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }


    }
}
