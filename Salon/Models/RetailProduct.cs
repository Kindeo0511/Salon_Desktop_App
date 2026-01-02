using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class RetailProduct 
    {
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public string product_name { get; set; }
        public string size_label { get; set; }
        public string brand { get; set; }
        public int content { get; set; }
        public decimal selling_price { get; set; }
        public int quantity { get; set; }



        // POS

        public int DiscountedQty { get; set; } = 0;
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsVatExempt { get; set; }
        public int QtyVatExempt { get; set; }
        public bool HasDiscountApplied { get; set; } = false;
        public bool IsFreeReward { get; set; } = false;
        public string DisplayFinalPrice
        {
            get
            {
                if (IsFreeReward)
                    return "FREE";
                else
                    return "";
            }
        }

        public decimal FinalPrice
        {
            get
            {
                var normalQty = quantity - DiscountedQty;
                var normalTotal = normalQty * selling_price;

                decimal discountedUnitPrice;

                if (IsVatExempt)
                {
                    var basePrice = selling_price / 1.12m; // remove VAT

                    if (DiscountPercent > 0)
                        discountedUnitPrice = basePrice * (1 - DiscountPercent / 100m);
                    else if (DiscountAmount > 0)
                        discountedUnitPrice = basePrice - DiscountAmount;
                    else
                        discountedUnitPrice = basePrice;
                }
                else
                {
                    if (DiscountPercent > 0)
                        discountedUnitPrice = selling_price * (1 - DiscountPercent / 100m);
                    else if (DiscountAmount > 0)
                        discountedUnitPrice = selling_price - DiscountAmount;
                    else
                        discountedUnitPrice = selling_price;
                }

                var discountedTotal = DiscountedQty * Math.Max(discountedUnitPrice, 0);

                return Math.Max(normalTotal + discountedTotal, 0);
            }
        }

    }
}
