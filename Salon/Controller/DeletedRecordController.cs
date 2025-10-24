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

        public async Task<IEnumerable<DeletedRecord>> GetAllDeletedRecordAsync() 
        {
            return await repo.AllAsync();
        }


        public async Task<IEnumerable<DeletedRecord>> GetAllDeletedRecordAsync(DateTime start, DateTime end)
        {
            return await repo.AllAsync(start, end);
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
    }
}
