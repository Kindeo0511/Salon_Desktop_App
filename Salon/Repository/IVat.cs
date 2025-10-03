using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IVat
    {
        void addTax(VatModel taxModel);
        IEnumerable<VatModel> getTax();
        int checkTax();
        void updateTax(VatModel taxModel);
    }
}
