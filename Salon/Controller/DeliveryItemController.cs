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
        public IEnumerable<DeliveryItemModel> GetDeliveryItemByInvoice(string invoice) 
        {
            return _repository.GetDeliveryItemsByInvoiceNumber(invoice);
        }

        public void AddDeliveryItem(DeliveryItemModel deliveryItemModel)
        {
             _repository.AddDeliveryItem(deliveryItemModel);

        }

        // DELIVERY REPORT

        public DeliveryItemModel GetTotalQty() 
        {
            return _repository.TotalQty();
        }

        public DeliveryItemModel GetTotalQty(DateTime start , DateTime end)
        {
            return _repository.TotalQty(start, end);
        }

        public DeliveryItemModel GetExpiredQty() 
        {
            return _repository.ExpiredQty();
        }


        public DeliveryItemModel GetExpiredQty(DateTime start, DateTime end)
        {
            return _repository.ExpiredQty(start, end);
        }

        public IEnumerable<DeliveryItemModel> GetDeliveryItems() 
        {
            return _repository.DeliveryItemList();
        }
        public IEnumerable<DeliveryItemModel> GetDeliveryItems(DateTime start, DateTime end)
        {
            return _repository.DeliveryItemList(start, end);
        }
    }
}
