using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public void AddPayment(Models.PaymentModel payment)
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute(@"
                INSERT INTO tbl_payment (appointment_id,discount_type, discount_amount,vat_amount, amount_paid, total_amount, change_amount, payment_method, reference_no, paid_at)
                VALUES (@AppointmentId,@DiscountType, @DiscountAmount,@VatAmount, @AmountPaid,@TotalAmount, @ChangeAmount, @PaymentMethod, @ReferenceNo, @PaidAt);", payment);
            }
               
        }
        public PaymentModel GetPayment(int AppointmentId)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT appointment_id AS AppointmentId, discount_type AS DiscountType, discount_amount as DiscountAmount, vat_amount AS VatAmount, amount_paid AS AmountPaid, total_amount AS TotalAmount, change_amount AS ChangeAmount, payment_method AS PaymentMethod, reference_no AS ReferenceNo FROM tbl_payment WHERE appointment_id = @AppointmentId";
                return con.QueryFirstOrDefault<PaymentModel>(sql, new { AppointmentId = AppointmentId });
            }
            
        }
    }
}
