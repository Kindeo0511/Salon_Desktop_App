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

        public bool AddPaymentMethod(PaymentMethodModel model) 
        {
            return repo.Add(model) > 0;
        }
        public bool UpdatePaymentMethod(PaymentMethodModel model) 
        {
            return repo.Update(model) > 0;
        }
        public bool SoftDeletePaymentMethod(int id) 
        {
            return repo.SoftDelete(id) > 0;
        }
        public bool HardDeletePaymentMethod(int id) 
        {
            return repo.HardDelete(id) > 0;
        }
    }
}
