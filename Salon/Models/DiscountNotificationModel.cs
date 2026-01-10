using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DiscountNotificationModel
    {
        public int notif_id { get; set; }
        public string customer_email { get; set; }
        public string customer_name { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public int is_sent { get; set; }
        public DateTime created_at { get; set; }
        public DateTime sent_at { get; set; }


    }
}
