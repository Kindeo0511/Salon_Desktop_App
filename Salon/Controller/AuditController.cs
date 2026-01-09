using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class AuditController
    {
        private readonly AuditRepository repo;
        public AuditController(AuditRepository repo) 
        {
            this.repo = repo;
        }

      

        public async Task<IEnumerable<AuditModel>> GetAllAuditAsync(int page_size, int off_set)
        {
            return await repo.AllAuditLogAsync(page_size, off_set);
        }

        public async Task<IEnumerable<AuditModel>> GetAllAuditAsync(DateTime start, DateTime end, int page_size, int off_set)
        {
            return await repo.AllAuditLogAsync(start, end, page_size, off_set);
        }
        public int GetTotalPages(int pageSize) 
        {
            return repo.TotalPages(pageSize);
        }

        public int GetTotalRecordCount()
        {
            return repo.TotalRecords(); // Assuming your repo has this method
        }

        public void CreateAudit(AuditModel model) 
        {
             repo.AddAudit(model);
        }
    }
}
