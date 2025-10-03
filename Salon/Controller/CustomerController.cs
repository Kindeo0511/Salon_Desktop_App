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
    }
}
