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

        public IEnumerable<DeliveryModel> GetAllDelivery()
        {
            return delivery.GetAllDelivery();
        }
        public async Task<IEnumerable<DeliveryModel>> GetDeliveryAsync() 
        {
            return await delivery.GetAllDeliveryAsync();
        }
        public int AddDelivery(DeliveryModel deliveryModel)
        {
            var id = delivery.AddDelivery(deliveryModel);
            return id;
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
