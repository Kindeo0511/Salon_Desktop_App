using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Models
{
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string DisplayCustomerName
        {
            get { return CustomerId.HasValue ? CustomerName : $"W-{AppointmentId.ToString().PadLeft(4, '0')}"; }
        }
        
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Customer_Type { get; set; }
        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed, Canceled
        public string PaymentStatus { get; set; } // e.g., Paid, Unpaid
        public int Durations { get; set; }
        public int ServiceId { get; set; }
        public int SubCategoryId { get; set; }
        public string Services { get; set; }
        public decimal TotalPrice { get; set; }
        public string BookingType { get; set; }

        public decimal selling_price { get; set; }
        public decimal vat_amount { get; set; }

        // SUMMARY DASHBOARD

        public int TotalAppointment { get; set; }

        // SUMMARY REPORT

        public decimal TotalSpent { get; set; }
        public int RepeatClient { get; set; }

        public string TopSpenderName { get; set; }
        public string ClientName { get; set; }
        public int Visit { get; set; }
        public decimal TotalSpend { get; set; }
        public DateTime LastVisit { get; set; }

    }
}
