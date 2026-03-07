using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class LoyaltyCardModel
    {

        //tbl_loyal_rewards MODEL
        public int reward_id { get; set; }
        public int service_id { get; set; }
        public string serviceName { get; set; }
        public int visit_required { get; set; }
        public string description { get; set; }


        //tbl_loyal_card MODEL

        public int card_id { get; set; }
        public string customer_name { get; set; }
        public int customer_id { get; set; }
        public string card_number { get; set; }
        public DateTime created_at { get; set; }

        // VISIT PROGRESS MODEL
        public string service_name { get; set; }
        public int visits { get; set; }
        public int required { get; set; }
        public string progress { get; set; }



    }
}
