using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServiceCart
    {
        public int ItemId { get; set; }
        public int service_cart_id { get; set; }
        public int InvoiceId { get; set; }
        public string ItemType { get; set; } // "Product" or "Service"
        public string Size { get; set; }
        public int? ProductId { get; set; }
        public int? ProductSizeId { get; set; }
        public string ProductUnitType { get; set; }
        public int? ServiceId { get; set; }
        public string ItemName { get; set; }
        public string SubCategory { get; set; }
        public int Duration { get; set; } // in minutes
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public int RefundQty { get; set; }
        public decimal TotalPrice => Price * Quantity;
        public int Voided { get; set; }
        public int Refunded { get; set; }
        public string Status
        {
            get
            {
                if (Voided == 1)
                    return "Void";
                else if (Refunded == 1)
                    return "Refunded";
                else return "Active";
            }
        }


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
                var normalQty = Quantity - DiscountedQty;
                var normalTotal = normalQty * Price;

                decimal discountedUnitPrice;

                if (IsVatExempt)
                {
                    var basePrice = Price / 1.12m; // remove VAT

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
                        discountedUnitPrice = Price * (1 - DiscountPercent / 100m);
                    else if (DiscountAmount > 0)
                        discountedUnitPrice = Price - DiscountAmount;
                    else
                        discountedUnitPrice = Price;
                }

                var discountedTotal = DiscountedQty * Math.Max(discountedUnitPrice, 0);

                return Math.Max(normalTotal + discountedTotal, 0);
            }
        }



        //public decimal FinalPrice
        //{
        //    get
        //    {   var normalQty = Quantity - DiscountedQty;

        //        var normalTotal = normalQty * Price;

        //        var discountedTotal = DiscountedQty * (Price - DiscountAmount); 

        //        return Math.Max(normalTotal + discountedTotal, 0); } }

        //    }
    }
}
    
