using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface ICustomer
    {
        IEnumerable<CustomerModel> GetAllCustomers();

        CustomerModel TotalCustomer();
        List<CustomerModel> GetCustomerBySearch(string key);
        void AddCustomer(CustomerModel customer);
        void UpdateCustomer(CustomerModel customer);
        void DeleteCustomer(int customerId);

        bool EmailExists(string email, int id = 0);
        bool ContactExists(string contact, int id = 0);
    }
}
