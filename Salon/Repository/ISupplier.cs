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
        Task<IEnumerable<SupplierModel>> GetAllSuppliersAsync(int PageSize, int Offset);
        //SupplierModel GetSupplierById(int id);
        int AddSupplier(SupplierModel supplier);
        int UpdateSupplier(SupplierModel supplier);
        int DeleteSupplier(int id);
        int ActivateSupplier(int id);
        int PermanentDelete(int id);
        //void DeleteSupplierById(int id);
        //bool SupplierExists(int id);
        //bool SupplierExists(SupplierModel supplier);

        bool SupplierExists(string name, int id);
        bool EmailExists(string email, int id);
        bool ContactExists(string name, int id);

    }
}
