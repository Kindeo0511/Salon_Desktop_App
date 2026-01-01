using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class BusinessHour
    {
        public int business_hour_id { get; set; }
        public string day_of_week { get; set; }
        public TimeSpan open_time { get; set; }
        public TimeSpan close_time { get; set; }

      
    }
}
