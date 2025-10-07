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


        // DISCOUNT REPORT

        public DiscountModel GetTotalDiscount() 
        {
            return discountRepository.TotalDiscount();
        }
        public DiscountModel GetTotalDiscount(DateTime start, DateTime end)
        {
            return discountRepository.TotalDiscount(start , end);
        }

        public DiscountModel GetTopItem()
        {
            return discountRepository.TopItem();
        }
        public DiscountModel GetTopItem(DateTime start, DateTime end)
        {
            return discountRepository.TopItem(start, end);
        }

        public DiscountModel GetTopDiscountedItem()
        {
            return discountRepository.DiscountedRate();
        }
        public DiscountModel GetTopDiscountedItem(DateTime start, DateTime end)
        {
            return discountRepository.DiscountedRate(start, end);
        }

        public IEnumerable<DiscountModel>  GetAllDiscounted()
        {
            return discountRepository.AllDiscounts();
        }
        public IEnumerable<DiscountModel> GetAllDiscounted(DateTime start, DateTime end)
        {
            return discountRepository.AllDiscounts(start, end);
        }
    }
}
