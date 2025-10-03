using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class OverHeadModel
    {
        public int over_head_id { get; set; }
        public decimal monthly_rent { get; set; }
        public decimal utilities_amount { get; set; }
        public decimal total_over_head { get; set; }
        public int total_working_hours { get; set; }
    }
}
