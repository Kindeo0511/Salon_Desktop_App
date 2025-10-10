using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class AuditModel
    {
        public int id { get; set; }
        public string action { get; set; }
        public string user { get; set; }
        public string module { get; set; }
        public string note { get; set; }
        public DateTime timestamp { get; set; }



    }
}
