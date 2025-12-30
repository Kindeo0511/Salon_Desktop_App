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

        public async Task<IEnumerable<SupplierModel>> RefreshSupplierAsync() 
        {
            return await repo.GetAllSuppliersAsync();
        }
        public bool AddSupplier(SupplierModel supplier)
        {
            return repo.AddSupplier(supplier) > 0;
        }
        public bool UpdateSupplier(SupplierModel supplier)
        {
           return repo.UpdateSupplier(supplier) > 0;
        }
        public bool DeleteSupplier(int id)
        {
            return repo.DeleteSupplier(id) > 0;
   
        }
        public bool RestoreSupplier(int id) 
        {
           return repo.ActivateSupplier(id) > 0;
        }

        public bool PermanentDeleteSupplier(int id) 
        {
            return repo.PermanentDelete(id) > 0;
        }
        public bool CheckSupplierExists(string name , int id = 0) 
        {
            return repo.SupplierExists(name, id);
        }

        public SupplierModel GetEmail(string email)
        {
            return repo.GetSupplierEmail(email);
        }
        public bool CheckIsSupplierIsUsed(int id) 
        {
            return repo.IsSupplierUsed(id);
        }
        public bool CheckEmailExists(string email, int id = 0)
        {
            return repo.EmailExists(email, id);
        }

        public bool CheckContactExists(string contact, int id = 0)
        {
            return repo.ContactExists(contact, id);
        }
    }
}
