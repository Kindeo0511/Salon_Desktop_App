using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public  class InvoiceController
    {
        private readonly InvoiceRepository repo;
        public InvoiceController(InvoiceRepository repo)
        {
            this.repo = repo;
        }
        public int GetInvoice(int id)
        {
            return repo.GetInvoiceById(id);
        }
        public int GetInvoiceNumber(string id)
        {
            return repo.GetInvoiceByNumber(id);
        }
        public int AddInvoice(InvoiceModel model)
        {
            return repo.CreateInvoice(model);
        }
        public int AddProductInvoice(InvoiceModel model)
        {
             return repo.CreateProductInvoice(model);
        }
        public void UpdateInvoice(InvoiceModel model)
        {
            repo.UpdateInvoice(model);
        }
        public IEnumerable<InvoiceModel> GetAllInvoice() 
        {
            return repo.GetInvoice();
        }
    }
}
