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

        public IEnumerable<AuditModel> GetAllAudit(int pageNumber, int pageSize) 
        {
            return repo.AllAuditLog(pageNumber, pageSize);
        }

        public IEnumerable<AuditModel> GetAllAudit(DateTime start, DateTime end, int pageNumber, int pageSize)
        {
            return repo.AllAuditLog(start, end, pageNumber, pageSize);
        }

        public async Task<IEnumerable<AuditModel>> GetAllAuditAsync(int pageNumber, int pageSize)
        {
            return await repo.AllAuditLogAsync(pageNumber, pageSize);
        }

        public async Task<IEnumerable<AuditModel>> GetAllAuditAsync(DateTime start, DateTime end, int pageNumber, int pageSize)
        {
            return await repo.AllAuditLogAsync(start, end, pageNumber, pageSize);
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
