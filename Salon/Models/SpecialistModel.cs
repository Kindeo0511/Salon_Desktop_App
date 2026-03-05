using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SpecialistModel
    {
        public int specialist_id { get; set; }
        public string name { get; set; }
        public int is_deleted { get; set; }

        public override string ToString() => name;
    }
}
