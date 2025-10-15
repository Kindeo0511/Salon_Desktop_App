using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class DeletedRecordRepository : IDeletedRecord
    {
        public IEnumerable<DeletedRecord> All() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_deleted_records";

                return con.Query<DeletedRecord>(sql);
            }
        }
        public IEnumerable<DeletedRecord> All(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_deleted_records WHERE deleted_on BETWEEN @start AND @end";

                return con.Query<DeletedRecord>(sql, new { start = start , end = end });
            }
        }
        public void Add(DeletedRecord model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_deleted_records (record_id, module, name, deleted_by, deleted_on) VALUES (@record_id, @module, @name, @deleted_by, @deleted_on)";

                 con.Execute(sql,model);
            }
        }
        public void delete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_deleted_records WHERE deleted_id = @id";

                con.Execute(sql, new { id = id});
            }
        }
    }
}
