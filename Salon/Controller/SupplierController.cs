using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class SupplierController
    {
        private readonly SupplierRepository repo;
        public SupplierController(SupplierRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<SupplierModel> GetAllSuppliers()
        {
            return repo.GetAllSuppliers();
        }
        public void AddSupplier(SupplierModel supplier)
        {
            repo.AddSupplier(supplier);
        }
        public void UpdateSupplier(SupplierModel supplier)
        {
            repo.UpdateSupplier(supplier);
        }
        public void DeleteSupplier(int id)
        {
            repo.DeleteSupplier(id);
        }
    }
}
