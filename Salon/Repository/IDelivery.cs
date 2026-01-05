using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IDelivery
    {
        IEnumerable<DeliveryModel> GetAllDelivery(int page_size, int off_set);
        IEnumerable<DeliveryItemModel> GetDeliveryInvoice();
        Task<IEnumerable<DeliveryModel>> GetAllDeliveryAsync(int page_size, int off_set);
        int AddDelivery(DeliveryModel delivery);

        bool DeliveryExists(string invoice);

        // DELIVERY REPORT

        DeliveryModel TotalDelivery();
        DeliveryModel TotalDelivery(DateTime start, DateTime end);
    }
}
