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
        public async Task<IEnumerable<DiscountModel>> GetAllDiscountAsync() 
        {
            return await discountRepository.GetAllDiscountAsync();
        }

        public IEnumerable<DiscountModel> GetDiscounts()
        {
            return discountRepository.Discounts();
        }
        public DiscountModel GetDiscountById(int id)
        {
            return discountRepository.GetDiscountById(id);
        }
        public int AddDiscount(DiscountModel model)
        {
            return discountRepository.AddDiscount(model);
        }
        public void UpdateDiscount(DiscountModel model)
        {
            discountRepository.UpdateDiscount(model);
        }
        public void DeleteDiscount(int id)
        {
            discountRepository.DeleteDiscount(id);
        }
        public void PermanentDeleteDiscount(int id) 
        {
            discountRepository.PermanentDelete(id);
        }
        public void RestoreDiscount(int id) 
        {
            discountRepository.RestoreDiscount(id);
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

        public void UpdateDiscountStatus(DiscountModel model) 
        {
            discountRepository.UpdateDiscountStatus(model);
        }

        // VALIDATION

        public List<DiscountModel> GetExpiringDiscounts(DateTime threshold) 
        {
            return discountRepository.GetExpiringDiscounts(threshold);
        }
        public bool CheckDiscountExists(string name, string code = "", decimal rate = 0, int id = 0) 
        {
            return discountRepository.DiscountExists(name, code, rate, id);
        }
    }
}
