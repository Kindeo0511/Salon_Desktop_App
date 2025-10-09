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

        public decimal discount_rate { get; set; }
        public DateTime? expiry_date { get; set; }
        public string status { get; set; }

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
