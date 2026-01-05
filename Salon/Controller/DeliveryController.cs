using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DeliveryController
    {
        private readonly DeliveryRepository delivery;

        public DeliveryController(DeliveryRepository delivery)
        {
            this.delivery = delivery;
        }
        public IEnumerable<DeliveryItemModel> GetDeliveryInvoice()
        {
            return delivery.GetDeliveryInvoice();
        }
        public IEnumerable<DeliveryModel> GetAllDelivery(int page_size, int off_set)
        {
            return delivery.GetAllDelivery(page_size, off_set);
        }
        public int GetTotalDeliveryCount()
        {
            return delivery.TotalDeliveryCount();
        }

        public async Task<IEnumerable<DeliveryModel>> GetDeliveryAsync(int page_size, int off_set) 
        {
            return await delivery.GetAllDeliveryAsync(page_size, off_set);
        }
        public int AddDelivery(DeliveryModel deliveryModel)
        {
            var id = delivery.AddDelivery(deliveryModel);
            return id;
        }
        public void UpdateDeliveryStatus() 
        {
            delivery.UpdateDeliveryStatus();
        }
        public bool GetDeliveryExists(string invoice) 
        {
            return delivery.DeliveryExists(invoice);
        }

        // DELIVERY REPORT

        public DeliveryModel GetTotalDelivery() 
        {
            return delivery.TotalDelivery();
        }

        public DeliveryModel GetTotalDelivery(DateTime start, DateTime end)
        {
            return delivery.TotalDelivery(start, end);
        }


    }
}
