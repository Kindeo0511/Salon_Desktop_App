using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IDeliveredItems
    {
        IEnumerable<DeliveryItemModel> GetDeliveryItems(int id);

        int AddDeliveryItem(DeliveryItemModel item);
    }
}
