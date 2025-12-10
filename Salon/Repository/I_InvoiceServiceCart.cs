using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface I_InvoiceServiceCart
    {
        BindingList<ServiceCart> GetAllServicesInCartById(int invoiceId);
        void AddServiceToCart(ServiceCart model);
        bool RemoveServiceFromCart(int id);
    }
}
