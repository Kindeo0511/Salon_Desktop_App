using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IRefund
    {
        IEnumerable<RefundModel> SelectedServices(int appointment_id);

        IEnumerable<RefundModel> Refunds();
        IEnumerable<RefundModel> Refunds(DateTime start, DateTime end);
        Task<IEnumerable<RefundModel>> RefundsAsync();
        Task<IEnumerable<RefundModel>> RefundsAsync(DateTime start, DateTime end);
        void Add(RefundModel model);

    }
}
