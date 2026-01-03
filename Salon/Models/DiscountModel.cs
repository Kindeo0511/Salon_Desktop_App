using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DiscountModel
    {
        public int discount_id { get; set; }
        public string discount_type { get; set; }
        public string promo_code { get; set; }
        public string discount_and_promo_code { get; set; }

        public decimal discount_rate { get; set; }
        public string mode { get; set; }
        public DateTime? expiry_date { get; set; }
        public int status { get; set; }
        public string text_status => status > 0 ? "Active" : "Inactive";
        public int vat_exempt { get; set; }
        public int is_defined { get; set; }
        public int is_deleted { get; set; }

        public int max_usage { get; set; }
        public int per_customer_limit { get; set; }
        public int notif_on_create { get; set; }
        public int notif_on_expired { get; set; }

        //  DISCOUNT REPORT

        public decimal TotalDiscount { get; set; }
        public string TopItem { get; set; }
        public decimal AverageDiscountRate { get; set; }

        // DISCOUNT REPORT GRID

        public DateTime Date { get; set; }
        public string Item { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }


    }
  
}
