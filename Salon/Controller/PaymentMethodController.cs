using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class PaymentMethodController
    {
        private readonly PaymentMethodRepository repo;

        public PaymentMethodController(PaymentMethodRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<PaymentMethodModel> GetAllPaymentMethod()
        {
            return repo.GetPaymentMethod();
        }
    }
}
