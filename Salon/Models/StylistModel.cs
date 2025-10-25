using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class StylistModel
    {
        public int StylistId { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; } // "09:00 AM"
        public string EndTime { get; set; }   // "05:00 PM"
        public bool IsWorking { get; set; }

        public int stylist_id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime birth_date { get; set; }
        public string email { get; set; }
        public string contactNumber { get; set; }
        public string address { get; set; }
        public string specialist { get; set; }

        public string status { get; set; }

        public string fullName { get; set; }
        public decimal daily_wage { get; set; }
        public decimal stylist_cost { get; set; }


        // REPORT SUMMARY

        public int TotalStaff { get; set; }
        public int TotalActive { get; set; }
        public int TotalInactive { get; set; }
        public decimal TotalSales { get; set; }

        public string StaffName { get; set; }
        public string Role { get; set; }
        public int Appointments { get; set; }
        public decimal Sales { get; set; }
        public string Availability { get; set; }
    


       

    }
}
