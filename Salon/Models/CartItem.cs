using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CartItem : INotifyPropertyChanged

    {
        public int ProductId { get; set; }
        public int ProductSizeId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set { if (_quantity != value) { _quantity = value; OnPropertyChanged(); OnPropertyChanged(nameof(LineTotal)); } }
        }

        public decimal LineTotal => UnitPrice * Quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

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
                var normalQty = Quantity - DiscountedQty;
                var normalTotal = normalQty * UnitPrice;

                decimal discountedUnitPrice;

                if (IsVatExempt)
                {
                    var basePrice = UnitPrice / 1.12m; // remove VAT

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
                        discountedUnitPrice = UnitPrice * (1 - DiscountPercent / 100m);
                    else if (DiscountAmount > 0)
                        discountedUnitPrice = UnitPrice - DiscountAmount;
                    else
                        discountedUnitPrice = UnitPrice;
                }

                var discountedTotal = DiscountedQty * Math.Max(discountedUnitPrice, 0);

                return Math.Max(normalTotal + discountedTotal, 0);
            }
        }


    }
}
