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
        void Add(RefundModel model);

    }
}
