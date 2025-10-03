using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class TimeSlot
    {
        public DateTime StartTime { get; set; }

        public TimeSlot(DateTime startTime)
        {
            this.StartTime = startTime;

        }

        public override string ToString()
        {
            return StartTime.ToString("hh:mm tt");
        }
    }
}
