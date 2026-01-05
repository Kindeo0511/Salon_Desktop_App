using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DeletedRecordController
    {
        private readonly DeletedRecordRepository repo;

        public DeletedRecordController(DeletedRecordRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<DeletedRecord> GetAllDeleteRecords() 
        {
            return repo.All();
        }

        public IEnumerable<DeletedRecord> GetAllDeleteRecords(DateTime start, DateTime end)
        {
            return repo.All(start , end);
        }

        public async Task<IEnumerable<DeletedRecord>> GetAllDeletedRecordAsync(int page_size, int off_set) 
        {
            return await repo.AllAsync(page_size, off_set);
        }


        public async Task<IEnumerable<DeletedRecord>> GetAllDeletedRecordAsync(DateTime start, DateTime end, int page_size, int off_set)
        {
            return await repo.AllAsync(start, end, page_size, off_set);
        }
        public void Add(DeletedRecord model) 
        {
            repo.Add(model);
        }
        public bool Delete(int id) 
        {
            repo.delete(id);

            return true;
        }
        public int GetTotalDeletedRecords() 
        {
            return repo.TotalDeletedRecord();
        }
    }
}
