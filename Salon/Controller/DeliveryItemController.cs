using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DeliveryItemController
    {
        private readonly DeliveredItemRepository _repository;
        public DeliveryItemController(DeliveredItemRepository repository)
        {
            this._repository = repository;
        }

        public IEnumerable<DeliveryItemModel> GetAllDeliveryItems(int id)
        {
            return _repository.GetDeliveryItems(id);
        }

        public int AddDeliveryItem(DeliveryItemModel deliveryItemModel)
        {
            return _repository.AddDeliveryItem(deliveryItemModel);

        }
    }
}
