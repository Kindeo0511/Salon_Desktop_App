using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface ISupplier
    {
        IEnumerable<SupplierModel> GetAllSuppliers();
        //SupplierModel GetSupplierById(int id);
        void AddSupplier(SupplierModel supplier);
        void UpdateSupplier(SupplierModel supplier);
        void DeleteSupplier(int id);
        //void DeleteSupplierById(int id);
        //bool SupplierExists(int id);
        //bool SupplierExists(SupplierModel supplier);

    }
}
