using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CustomerModel
    {
        public int customer_id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string customer_name { get; set; }
        public string customer_type { get; set; }
       public int loyalty_points { get; set; }

        public string status { get; set; }
        public string fullName
        {
        
  
            get
            {
                return $"{firstName} {middleName} {lastName} - {email}";
            }
        }

        // REPORT SUMMARY

        public int TotalCustomer { get; set; }

    }
}
