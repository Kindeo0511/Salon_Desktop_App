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

        Task<IEnumerable<ServiceProductUsageModel>> GetAllServiceProductsAsync(int id);
        IEnumerable<ServiceProductUsageModel> GetTotalProductCost();
        void AddServiceProduct(ServiceProductUsageModel model);
        void UpdateServiceProduct(ServiceProductUsageModel model);
        void DeleteServiceProduct(int id);
        void RestoreServiceProduct(int id);
        void PermanentDelete(int id);

        bool ProductUsageExists(int product_id,int service_id, int excludeId);
    }
}
