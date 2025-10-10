using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class AuditRepository : IAudit
    {
        public IEnumerable<AuditModel> AllAuditLog(int pageNumber, int pageSize) 
        {
            using (var con = Database.GetConnection()) 
            {
                int offset = (pageNumber - 1) * pageSize;
                var sql = "SELECT * FROM tbl_audit_trail ORDER BY id DESC LIMIT @PageSize OFFSET @Offset";
                return con.Query<AuditModel>(sql, new { PageSize = pageSize, Offset = offset }).ToList();

            }
        }
        public int TotalPages(int pageSize)
        {
            using (var con = Database.GetConnection())
            {
                var count = con.ExecuteScalar<int>("SELECT COUNT(*) FROM tbl_audit_trail");
                return (int)Math.Ceiling(count / (double)pageSize);


            }
        }
        public int TotalRecords() 
        {
            using (var con = Database.GetConnection())
            {
                return con.ExecuteScalar<int>("SELECT COUNT(*) FROM tbl_audit_trail");
            }

        }
        public void AddAudit(AuditModel audit) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_audit_trail (user, action, module, note, timestamp) VALUES (@user, @action, @module, @note, @timestamp)";

                con.Execute(sql, audit);
            }
        }
    }
}
