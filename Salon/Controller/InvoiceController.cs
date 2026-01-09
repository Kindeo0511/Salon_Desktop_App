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
        public IEnumerable<InvoiceModel> GetAllInvoice(DateTime start, DateTime end)
        {
            return repo.GetInvoice(start, end);
        }


        // SALES REPORT 
        public int GetCountTotalInvoice() 
        {
            return repo.CountTotalInvoice();
        }
        public InvoiceModel GetSalesReportSummaryView() 
        {
            return repo.SalesReportSummary();
        }
        public IEnumerable<InvoiceServicesCart> GetSalesReportView(int page_size, int off_set)
        {
            return repo.SalesReportView(page_size, off_set);
        }
        public IEnumerable<InvoiceServicesCart> GetSalesReportView(DateTime start, DateTime end, int page_size, int off_set)
        {
            return repo.SalesReportView(start, end, page_size, off_set);
        }
        public InvoiceModel GetTotalServiceSaleView()
        {
            return repo.TotalServiceSaleView();
        }
        public InvoiceModel GetTotalProductSaleView()
        {
            return repo.TotalProductSaleView();
        }

    }
}
