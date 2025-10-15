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
        private readonly RefundRepository repo;
        public RefundController(RefundRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<RefundModel> GetSelectedServices(int appointment_id) 
        {
            return repo.SelectedServices(appointment_id);
        }
        public IEnumerable<RefundModel> GetRefunds() 
        {
            return repo.Refunds();
        }

        public IEnumerable<RefundModel> GetRefunds(DateTime start, DateTime end)
        {
            return repo.Refunds(start , end);
        }
        public void AddRefund(RefundModel model) 
        {
            repo.Add(model);
        }
    }
}
