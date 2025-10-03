using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed, Canceled
        public string PaymentStatus { get; set; } // e.g., Paid, Unpaid
        public int Durations { get; set; }
        public string Services { get; set; }
        public decimal TotalPrice { get; set; }
        public string BookingType { get; set; }

        public decimal selling_price { get; set; }
        public decimal vat_amount { get; set; }

        // SUMMARY DASHBOARD

        public int TotalAppointment { get; set; }
    }
}
