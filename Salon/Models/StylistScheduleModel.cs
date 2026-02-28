using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class StylistScheduleModel
    {
        public int weekly_id { get; set; }
        public string day_of_week { get; set; }
        public int stylist_id { get; set; }
        public int is_duty { get; set; }


    }
}
