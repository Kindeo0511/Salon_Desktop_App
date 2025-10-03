using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class BookingSummary
    {
        public CustomerModel CustomerModel { get; set; }
        public List<ServiceItemSelected> SelectedServices { get; set; } = new List<ServiceItemSelected>();
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public TimeSpan AppointmentEndTime { get; set; }
        public string BookingType { get; set; }
    }
}
