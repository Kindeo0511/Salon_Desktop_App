using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IDiscount
    {
        IEnumerable<DiscountModel> GetAllDiscounts();

        DiscountModel GetDiscountById(int id);

        void AddDiscounts(DiscountModel model);
        void UpdateDiscounts(DiscountModel model);
        void DeleteDiscounts(int id);
    }
}
