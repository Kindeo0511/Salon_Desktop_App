using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ServicePriceController
    {
        private readonly ServicePriceRepository repo;
        public ServicePriceController(ServicePriceRepository repo) 
        {
            this.repo = repo;
        }
        public IEnumerable<ServicePriceModel> ShowAllServices() 
        {
            return repo.GetAllServicePrice();
        }
        public ServicePriceModel GetServicePrice(int SelectedServiceNameID)
        {
            return repo.GetServicePrice(SelectedServiceNameID);
        }

        public void AddServicePrice(ServicePriceModel servicePrice) 
        {
            repo.AddServicePrice(servicePrice);
        }
        public void UpdateServicePrice(ServicePriceModel servicePrice) 
        {
            repo.UpdateServicePrice(servicePrice);
        }

        public void DeleteServicePrice(int id) 
        {
            repo.DeleteServicePrice(id);
        }
    }
}
