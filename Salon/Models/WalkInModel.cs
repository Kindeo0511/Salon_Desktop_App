using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class WalkInModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int stylist_id { get; set; }
        public string StylistName { get; set; }
        public int subCategoryId { get; set; }
        public int serviceName_id { get; set; }
        public string serviceName { get; set; }
        public decimal selling_price { get; set; }
        public DateTime date { get; set; }
        public TimeSpan start_time { get; set; }
        public TimeSpan end_time { get; set; }
        public string status { get; set; }
        public string payment_status { get; set; }
        public string cancel_request { get; set; }
    }
}
