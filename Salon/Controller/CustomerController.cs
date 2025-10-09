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

        public CustomerModel GetTotalCustomer() 
        {
            return repo.TotalCustomer();
        }
        public List<CustomerModel> GetCustomerBySearch(string key)
        {
            return repo.GetCustomerBySearch(key);
        }
        public void AddCustomer(CustomerModel customer)
        {
            repo.AddCustomer(customer);
        }
        public void UpdateCustomer(CustomerModel customer)
        {
            repo.UpdateCustomer(customer);
        }
        public void DeleteCustomer(int customerId)
        {
            repo.DeleteCustomer(customerId);
        }
        public bool CheckEmailExists(string email, int id = 0) 
        {
            return repo.EmailExists(email, id);
        }
        public bool CheckContactExists(string email, int id = 0)
        {
            return repo.ContactExists(email, id);
        }
    }
}
