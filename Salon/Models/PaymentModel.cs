using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public int AppointmentId { get; set; }
        public decimal AmountPaid { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime PaidAt { get; set; }
        public int UserId { get; set; }



    }
}
