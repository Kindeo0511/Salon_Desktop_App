using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DiscountController
    {
        private readonly DiscountRepository discountRepository;

        public DiscountController(DiscountRepository discountRepository)
        {
            this.discountRepository = discountRepository;
        }

        public IEnumerable<DiscountModel> getAllDiscount()
        {
            return discountRepository.getAllDiscounts();
        }
        public DiscountModel GetDiscountById(int id)
        {
            return discountRepository.GetDiscountById(id);
        }
        public void AddDiscount(DiscountModel model)
        {
            discountRepository.AddDiscount(model);
        }
        public void UpdateDiscount(DiscountModel model)
        {
            discountRepository.UpdateDiscount(model);
        }
        public void DeleteDiscount(int id)
        {
            discountRepository.DeleteDiscount(id);
        }
    }
}
