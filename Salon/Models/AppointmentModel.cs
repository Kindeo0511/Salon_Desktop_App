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
        public int AppointmentServiceId { get; set; }
        public int AppointmentId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }

      public string DisplayCustomerName
        {
            get
            {
                if (CustomerId.HasValue && !string.IsNullOrEmpty(CustomerName))
                {
                    // Registered customer
                    return CustomerName;
                }
                else if (AppointmentType == "Appointment")
                {
                    // Appointment without customer record (walk-in appointment)
                    return $"A-{AppointmentId.ToString().PadLeft(4, '0')}";
                }
                else if (AppointmentType == "Walk-In")
                {
                    // Pure walk-in (no appointment, no customer record)
                    return $"W-{AppointmentId.ToString().PadLeft(4, '0')}";
                }
                else
                {
                    // No valid identifiers
                    return "-";
                }

            }
        }
        
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerType { get; set; }
        public int LoyaltyPoints { get; set; }
        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public string AppointmentType { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
   
        public string DisplayTime =>
            (StartTime != DateTime.MinValue && EndTime != DateTime.MinValue)
            ? $"{StartTime:hh:mm tt} - {EndTime:hh:mm tt}"
            : "-";

     
        public string AvailabilityNext =>
            DutyStatus == "Busy" && EndTime != DateTime.MinValue
                ? EndTime.ToString("hh:mm tt")
                : DutyStatus == "Waiting" && StartTime != DateTime.MinValue
                    ? StartTime.ToString("hh:mm tt")
                    : "Available Now";


        public DateTime EndDuration { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed, Canceled
        public string DutyStatus { get; set; } // e.g., On Duty, Off Duty
        public string PaymentStatus { get; set; } // e.g., Paid, Unpaid
        public int Duration { get; set; }
        public int ServiceId { get; set; }
        public int SubCategoryId { get; set; }
        public string Services { get; set; }
        public decimal TotalPrice { get; set; }


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
