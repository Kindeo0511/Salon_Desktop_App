using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IServiceProductUsage
    {
        IEnumerable<ServiceProductUsageModel> GetAllServiceProducts(int id);

        IEnumerable<ServiceProductUsageModel> GetAllServiceProductsAsync(int id);

        int GetProductUsageCount(int id);
        IEnumerable<ServiceProductUsageModel> GetTotalProductCost();
        int AddServiceProduct(ServiceProductUsageModel model);
        int UpdateServiceProduct(ServiceProductUsageModel model);
        int DeleteServiceProduct(int id);
        int RestoreServiceProduct(int id);
        int PermanentDelete(int id);

        bool ProductUsageExists(int product_id,int service_id, int excludeId);
    }
}
