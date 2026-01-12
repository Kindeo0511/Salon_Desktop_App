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

        public async Task<IEnumerable<DeletedRecord>> AllAsync(int page_size, int off_set) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_deleted_records LIMIT @page_size OFFSET @off_set";

                var result = await con.QueryAsync<DeletedRecord>(sql, new { page_size, off_set});

                return result;
            }
        }

        public async Task<IEnumerable<DeletedRecord>> AllAsync(DateTime start, DateTime end, int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_deleted_records WHERE deleted_on BETWEEN @start AND @end LIMIT @page_size OFFSET @off_set";

                var result = await con.QueryAsync<DeletedRecord>(sql, new { start = start, end = end, page_size, off_set });

                return result;
            }
        }
        public void Add(DeletedRecord model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_deleted_records (record_id,sub_id, module, name, deleted_by, deleted_on) VALUES (@record_id,@sub_id, @module, @name, @deleted_by, @deleted_on)";

                 con.Execute(sql,model);
            }
        }
        public void delete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_deleted_records WHERE deleted_id = @id OR record_id = @id";

                con.Execute(sql, new { id = id});
            }
        }
        public void PermanentDelete(int id) 
        {
        
        }
        public int TotalDeletedRecord() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_deleted_records";
                return con.ExecuteScalar<int>(sql);
            }
        }
    }
}
