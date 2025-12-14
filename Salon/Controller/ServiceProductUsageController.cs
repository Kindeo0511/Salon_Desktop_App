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
        public async Task<IEnumerable<ServiceProductUsageModel>> GetAllServiceProductsAsync(int id) 
        {
            return await _repository.GetAllServiceProductsAsync(id);
        }
        public IEnumerable<ServiceProductUsageModel> GetProductCost()
        {
            return _repository.GetTotalProductCost();
        }

        public void AddServiceProduct(ServiceProductUsageModel model)
        {
            _repository.AddServiceProduct(model);
        }
        public void UpdateServiceProduct(ServiceProductUsageModel model)
        {
            _repository.UpdateServiceProduct(model);
        }

        public void DeleteServiceProduct(int id)
        {
            _repository.DeleteServiceProduct(id);
        }
        public void PermanentDeleteServiceProductUsage(int id) 
        {
            _repository.PermanentDelete(id);
        }
        public void RestoreServiceProduct(int id)
        {
            _repository.RestoreServiceProduct(id);
        }
        public bool ProductUsageExists(int product_id, int service_id, int excludeId = 0)

        {
            return _repository.ProductUsageExists(product_id, service_id, excludeId);
        }
    }
}
