using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DiscountUsageController
    {
        private readonly DiscountUsageRepository repo;
        public DiscountUsageController(DiscountUsageRepository repo) 
        {
            this.repo = repo;
        }

        public int GetUsageCount(int discount_id , int customer_id) 
        {
            return repo.UsageCount(discount_id, customer_id);
        }

        public void AddDiscountUsage(DiscountUsageModel model) 
        {
            repo.AddUsage(model);
        }
    }
}
