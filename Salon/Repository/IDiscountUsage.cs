using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IDiscountUsage
    {
        int UsageCount(int discount_id,int customer_id);
        void AddUsage(DiscountUsageModel usage);
        
    }
}
