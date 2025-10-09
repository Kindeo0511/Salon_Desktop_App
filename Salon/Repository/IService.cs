using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IService
    {
        IEnumerable<ServiceModel> getAllServices();
        ServiceModel GetTotalServices();
        void addService(ServiceModel service);
        void updateService(ServiceModel service);
        void deleteService(int id);


        bool ServiceExists(string name, int id);
    }
}
