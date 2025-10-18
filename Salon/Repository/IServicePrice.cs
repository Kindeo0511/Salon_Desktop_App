using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IServicePrice
    {
        IEnumerable<ServicePriceModel> GetAllServicesByName(string key = "");
        IEnumerable<ServicePriceModel> GetAllServicePrice();
        ServicePriceModel GetServicePrice(int SelectedServiceNameID);
        void AddServicePrice(ServicePriceModel servicePrice);
        void UpdateServicePrice(ServicePriceModel servicePrice);
        void DeleteServicePrice(int id);
        void RestoreServicePrice(int id);

        bool IsServicePriceExist(int spid, int id);


    }
}
