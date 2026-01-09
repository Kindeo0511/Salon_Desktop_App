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
       

        public async Task<IEnumerable<AuditModel>> AllAuditLogAsync(int pageSize, int off_set) 
        {

            using (var con = Database.GetConnection())
            {
                
                var sql = "SELECT * FROM tbl_audit_trail ORDER BY id DESC LIMIT @PageSize OFFSET @Offset";
                var result = await con.QueryAsync<AuditModel>(sql, new { PageSize = pageSize, Offset = off_set });

                return result.ToList();

            }
        }

        public async Task<IEnumerable<AuditModel>> AllAuditLogAsync(DateTime start, DateTime end, int pageSize, int offset)
        {

            using (var con = Database.GetConnection())
            {
           
                var sql = "SELECT * FROM tbl_audit_trail WHERE timestamp BETWEEN @start AND @end ORDER BY id DESC LIMIT @PageSize OFFSET @Offset ";
                var result = await con.QueryAsync<AuditModel>(sql, new { start, end, PageSize = pageSize, Offset = offset });

                return result.ToList();

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
