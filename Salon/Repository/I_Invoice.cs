using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface I_Invoice
    {
     int CreateInvoice(InvoiceModel model);
     int GetInvoiceById(int id);
     void UpdateInvoice(InvoiceModel model);
    }
}
