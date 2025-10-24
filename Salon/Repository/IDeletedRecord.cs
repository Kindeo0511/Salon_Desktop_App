using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IDeletedRecord
    {
        IEnumerable<DeletedRecord> All();
        IEnumerable<DeletedRecord> All(DateTime start, DateTime end);

        Task<IEnumerable<DeletedRecord>> AllAsync();
        Task<IEnumerable<DeletedRecord>> AllAsync(DateTime start, DateTime end);
        void Add(DeletedRecord model);
        void delete(int id);
    }
}
