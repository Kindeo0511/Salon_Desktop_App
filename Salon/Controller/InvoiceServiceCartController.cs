using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class InvoiceServiceCartController
    {
        private readonly InvoiceServiceRepository repo;

        public InvoiceServiceCartController(InvoiceServiceRepository repo)
        {
            this.repo = repo;
        }

        public BindingList<ServiceCart> GetInvoiceServiceCartByInvoiceId(int invoiceId)
        {
            return repo.GetAllServicesInCartById(invoiceId);
        }
        public IEnumerable<InvoiceServicesCart> GetInvoiceForVoidAndRefundById(int id) 
        {
            return repo.GetInvoiceForVoidAndRefund(id);
        }
        public void AddServiceToInvoiceCart(ServiceCart model)
        {
            repo.AddServiceToCart(model);
        }
        public void UpdateServiceInInvoiceCart(ServiceCart model) 
        {
            repo.UpdateServicesInvoice(model);
        }
        public void VoidProductByInvoiceId(int id, string status) 
        {
            repo.UpdateServiceToCart(id, status);
        }
        public void GetInvoiceServiceById(int invoice_id, int service_id) 
        {
            repo.GetServiceInvoiceId(invoice_id, service_id);
        }
        public void RefundProduct(int id) 
        {
            repo.RefundServiceToCart(id);
        }
        public bool DeleteServiceFromInvoiceCart(int id)
        {
            return repo.RemoveServiceFromCart(id);
        }
        public void RemoveProduct(int id) 
        {
            repo.RemoveProductFromCart(id);
        }
        public ServiceCart GetServiceFromInvoiceCart(int id) 
        {
            return repo.GetInvoiceCartId(id);
        }
    }
}
