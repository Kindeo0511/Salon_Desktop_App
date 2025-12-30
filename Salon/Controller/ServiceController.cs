using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ServiceController
    {
        private readonly ServiceRepository repo;
        public ServiceController(ServiceRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<ServiceModel> getServices()
        {
            return repo.getAllServices();
        }

        public async Task<IEnumerable<ServiceModel>> GetAllServicsAsync() 
        {
            return await repo.GetAllServicesAsync();
        }
        public ServiceModel TotalServices() 
        {
            return repo.GetTotalServices();
        }
        public async Task<ServiceModel> TotalServicesAsync() 
        {
            return await repo.GetTotalServicesAsync();
        }
        public List<ServiceModel> getServiceByName(string key) 
        {
            return repo.GetAllServicesByName(key);
        }
        public List<ServiceModel> getServicesById(int id)
        {
            return repo.GetAllServicesbySubcategoryId(id);
        }
        public int addService(ServiceModel service)
        {
            return repo.addService(service);
        }
        public bool updateService(ServiceModel service)
        {
            return repo.updateService(service) > 0;
        }
        public bool deleteService(int id)
        {
            return repo.deleteService(id) > 0;
        }
        public bool IsServiceUsed(int id) 
        {
            return repo.ServiceIsUsed(id);
        }

        public bool RestoreServices(int id) 
        {
            return repo.RestoreService(id) > 0;
        }

        public bool PermanentDeleteService(int id) 
        {
            return repo.PermanentDelete(id) > 0;
        }
        public bool CheckServiceExists(string name, int scid, int id) 
        {
           return repo.ServiceExists(name, scid, id);
        }
        public ServiceModel GetServiceAndCategory(string name, int id) 
        {
            return repo.GetServiceAndCategory(name, id);
        }
    }
}
