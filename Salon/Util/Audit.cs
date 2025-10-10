using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Util
{
    public static class Audit
    {
        public static void AuditLog(DateTime timestamp, string action, string user, string module, string notes) 
        {
            var repo = new AuditRepository();
            var controller = new AuditController(repo);

            var model = new AuditModel
            {
                action = action,
                user = user,
                module = module,
                note = notes,
                timestamp = timestamp,
            };

            controller.CreateAudit(model);
        }
    }
}
