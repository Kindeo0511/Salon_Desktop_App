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

        public IEnumerable<ServiceProductUsageModel> GetAllServiceProducts(int id)
        {
            return _repository.GetAllServiceProducts(id);
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

        public bool CheckProductUsageExists(int p_id, int id = 0) 
        {
            return _repository.ProductUsageExists(p_id, id);
        }
    }
}
