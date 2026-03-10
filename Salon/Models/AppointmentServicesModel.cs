using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class AppointmentServicesModel
    {
        public int AppointmentServiceId { get; set; }
        public int AppointmentId { get; set; }
        public int ServiceId { get; set; }
        public int? StylistId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string StylistName => $"{firstName} {lastName}".Trim();
        public string ServiceName { get; set; }
        public int Duration { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
         public string DisplayTime =>
            (StartTime.HasValue && EndTime.HasValue)
            ? $"{StartTime.Value:hh:mm tt} - {EndTime.Value:hh:mm tt}"
            : "-";
        public string Status { get; set; }

        public int bookings { get; set; }
       

    }
}
