using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class PaymentController
    {
        private readonly IPaymentRepository _repo;

        public PaymentController(IPaymentRepository repo)
        {
            this._repo = repo;
        }
        public void CreatePayment(PaymentModel paymentModel)
        {
            _repo.AddPayment(paymentModel);
        }
        public PaymentModel GetPaymentByAppointmentId(int appointment_id)
        {
            return _repo.GetPayment(appointment_id);
        }

    }
}
