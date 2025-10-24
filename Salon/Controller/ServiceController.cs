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
        public void addService(ServiceModel service)
        {
            repo.addService(service);
        }
        public void updateService(ServiceModel service)
        {
            repo.updateService(service);
        }
        public void deleteService(int id)
        {
            repo.deleteService(id);
        }

        public void RestoreServices(int id) 
        {
            repo.RestoreService(id);
        }
        public bool CheckServiceExists(string name, int scid, int id) 
        {
           return repo.ServiceExists(name, scid, id);
        }
    }
}
