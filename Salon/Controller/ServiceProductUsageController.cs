using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ServiceProductUsageController
    {
        private readonly ServiceProductUsageRepository _repository;

        public ServiceProductUsageController(ServiceProductUsageRepository _repository)
        {
            this._repository = _repository;
        }

        public int GetProductUsageCount(int id) 
        {
            return _repository.GetProductUsageCount(id);
        }
        public IEnumerable<ServiceProductUsageModel> GetAllServiceProducts(int id)
        {
            return _repository.GetAllServiceProducts(id);
        }
        public IEnumerable<ServiceProductUsageModel> GetAllServiceProductsAsync(int id) 
        {
            return _repository.GetAllServiceProductsAsync(id);
        }
        public IEnumerable<ServiceProductUsageModel> GetProductCost()
        {
            return _repository.GetTotalProductCost();
        }

        public bool AddServiceProduct(ServiceProductUsageModel model)
        {
            return _repository.AddServiceProduct(model) > 0;
        }
        public bool UpdateServiceProduct(ServiceProductUsageModel model)
        {
            return _repository.UpdateServiceProduct(model) > 0;
        }

        public bool DeleteServiceProduct(int id)
        {
            return _repository.DeleteServiceProduct(id) > 0;
        }
        public bool PermanentDeleteServiceProductUsage(int id) 
        {
           return _repository.PermanentDelete(id) > 0;
        }
        public bool RestoreServiceProduct(int id)
        {
           return _repository.RestoreServiceProduct(id) > 0;
        }
        public bool ProductUsageExists(int product_id, int service_id, int excludeId = 0)

        {
            return _repository.ProductUsageExists(product_id, service_id, excludeId);
        }
        public ServiceProductUsageModel GetServiceProductUsage(int product_id, int service_id, string brand, int qty) 
        {
            return _repository.GetServiceUsage(product_id, service_id, brand, qty);
        }
        public bool IsProductUsedInServices(int product_id) 
        {
            return _repository.IsServiceProductUsed(product_id);
        }
    }
}
