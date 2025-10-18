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
        void RestoreDiscounts(int id);

        // DISCOUNT REPORT

        DiscountModel TotalDiscount();
        DiscountModel TotalDiscount(DateTime start, DateTime end);
        DiscountModel TopItem();
        DiscountModel TopItem(DateTime start, DateTime end);
        DiscountModel DiscountedRate();
        DiscountModel DiscountedRate(DateTime start, DateTime end);

        // GRID DATA

        IEnumerable<DiscountModel> AllDiscounts();
        IEnumerable<DiscountModel> AllDiscounts(DateTime start, DateTime end);


        bool DiscountExists(string name, int id);
    }
}
