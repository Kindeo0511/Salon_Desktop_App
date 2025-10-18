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
        public int discount_id { get; set; }
        public int customer_id { get; set; }
        public string channel { get; set; }
        public string status { get; set; }
        public DateTime scheduled_on { get; set; }
        public DateTime sent_on { get; set; }
        public string error_message { get; set; }

    }
}
