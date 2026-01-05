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

        Task<IEnumerable<DeletedRecord>> AllAsync(int page_size, int off_set);
        Task<IEnumerable<DeletedRecord>> AllAsync(DateTime start, DateTime end, int page_size, int off_set);
        void Add(DeletedRecord model);
        void delete(int id);
        void PermanentDelete(int id);

    }
}
