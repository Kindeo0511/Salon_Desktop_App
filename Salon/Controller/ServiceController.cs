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
        public ServiceModel TotalServices() 
        {
            return repo.GetTotalServices();
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
    }
}
