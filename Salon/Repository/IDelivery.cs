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
        IEnumerable<DeliveryModel> GetAllDelivery();

        int AddDelivery(DeliveryModel delivery);
    }
}
