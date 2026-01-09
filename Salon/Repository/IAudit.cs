using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IAudit
    {
       

        Task<IEnumerable<AuditModel>> AllAuditLogAsync(int pageNumber, int pageSize);
        Task<IEnumerable<AuditModel>> AllAuditLogAsync(DateTime start, DateTime end, int pageNumber, int pageSize);
        int TotalPages(int pageSize);
        int TotalRecords();
        void AddAudit(AuditModel audit);
    }
}
