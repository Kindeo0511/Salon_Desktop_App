using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class RefundController
    {
        private readonly InvoiceRefundRepository repo;

        public RefundController(InvoiceRefundRepository repo)
        {
            this.repo = repo;
        }

        public void AddRefund(InvoiceRefundModel model) 
        {
            repo.AddRefund(model);
        }
        public void UpdateRefundStatus() 
        {
            repo.UpdateRefundStatus();
        }
        public int CheckRefundQty(int id) 
        {
            return repo.CheckRefundQty(id);
        }
    }
}
