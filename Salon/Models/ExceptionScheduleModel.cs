using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ExceptionScheduleModel
    {
        public int id { get; set; }
        public int stylist_id { get; set; }
        public DateTime date { get; set; }
        public TimeSpan start_time { get; set; }
        public TimeSpan end_time { get; set; }
        public bool is_available { get; set; }
        public string reason { get; set; }


    }
}
