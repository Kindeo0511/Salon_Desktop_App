using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class RefundHistoryController
    {
        private readonly Refund_Repository repo;
        public RefundHistoryController(Refund_Repository repo) 
        {
            this.repo = repo;
        }
        public IEnumerable<RefundModel> RefundView(int pageSize, int off_set) 
        {
            return repo.Refund_View(pageSize, off_set);
        }
        public IEnumerable<RefundModel> RefundView(DateTime start, DateTime end, int pageSize, int offset)
        {
            return repo.Refund_View(start,end,pageSize, offset);
        }
        public int TotalRefunds() 
        {
            return repo.TotalRefunds();
        }
    }
}
