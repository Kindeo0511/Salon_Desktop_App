using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class CustomerController
    {
        private readonly CustomerRepository repo;
        public CustomerController(CustomerRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<CustomerModel> GetAllCustomer()
        {
            return repo.GetAllCustomers();
        }

        public async Task<IEnumerable<CustomerModel>> RefreshCustomerAsync(int PageSize, int OffSet) 
        {
            return await repo.GetAllCustomersAsync(PageSize, OffSet);
        }
        public CustomerModel GetTotalCustomer() 
        {
            return repo.TotalCustomer();
        }
        public int TotalCustomerCount() 
        {
            return repo.GetTotalCustomer();
        }
        public List<CustomerModel> GetCustomerBySearch(string key)
        {
            return repo.GetCustomerBySearch(key);
        }
        public CustomerModel GetCustomerById(int id) 
        {
            return repo.GetCustomerById(id);
        }
        public bool AddCustomer(CustomerModel customer)
        {
           return repo.AddCustomer(customer) > 0;
        }
        public CustomerModel GetEmail(string email)
        {
            return repo.GetCustomerEmail(email);
        }
        public bool UpdateCustomer(CustomerModel customer)
        {
            return repo.UpdateCustomer(customer) > 0;
        }
        public bool DeleteCustomer(int customerId)
        {
            return repo.DeleteCustomer(customerId) > 0;
        }
        public bool RestoreCustomer(int customerId) 
        {
            return repo.ActivateCustomer(customerId) > 0;
        }
        public void UpdateCustomerPoints(CustomerModel model) 
        {
            repo.UpdateCustomeLoyaltyPoint(model);
        }
        public void DeductCustomerPoints(CustomerModel model) 
        {
            repo.SubtractCustomerLoyaltyPoints(model);
        }
        public bool PermanentDeleteCustomer(int id) 
        {
            return repo.PermanentDelete(id) > 0;
        }
        public bool CheckEmailExists(string email, int id = 0) 
        {
            return repo.EmailExists(email, id);
        }
        public bool CheckContactExists(string email, int id = 0)
        {
            return repo.ContactExists(email, id);
        }
        public bool CheckIsCustomerUsed(int id) 
        {
            return repo.IsCustomerIsUsed(id);
        }
    }
}
