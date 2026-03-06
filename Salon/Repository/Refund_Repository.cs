using Dapper;
using iText.Kernel.Geom;
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
    public class Refund_Repository
    {
        public IEnumerable<RefundModel> Refund_View(int pageSize, int off_set) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM refund_view ORDER BY refund_id DESC LIMIT @PageSize OFFSET @Offset";
                return con.Query<RefundModel>(sql, new { PageSize = pageSize, Offset = off_set }).ToList();
            }
        }
        public IEnumerable<RefundModel> Refund_View(DateTime start, DateTime end, int pageSize, int offset)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM refund_view  WHERE refunded_at BETWEEN @start AND @end ORDER BY refund_id DESC LIMIT @PageSize OFFSET @Offset ";
                return con.Query<RefundModel>(sql, new { start, end, PageSize = pageSize, Offset = offset }).ToList();
            }
        }

        public int TotalRefunds() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM refund_view";
                return con.ExecuteScalar<int>(sql);
            }
        }

    }
}
