using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class BusinessHour
    {
        public string DayofWeek { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }

        public BusinessHour(string dayOfWeek, TimeSpan openTime, TimeSpan closeTime)
        {
            this.DayofWeek = dayOfWeek;
            this.OpenTime = openTime;
            this.CloseTime = closeTime;
        }
    }
}
