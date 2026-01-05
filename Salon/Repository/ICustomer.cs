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
        Task<IEnumerable<CustomerModel>> GetAllCustomersAsync(int PageSize, int OffSet);
        CustomerModel TotalCustomer();
        List<CustomerModel> GetCustomerBySearch(string key);
        CustomerModel GetCustomerById(int id);
        int AddCustomer(CustomerModel customer);
        int UpdateCustomer(CustomerModel customer);
        int DeleteCustomer(int customerId);
        int PermanentDelete(int customerId);
        int ActivateCustomer(int customerId);

        bool EmailExists(string email, int id = 0);
        bool ContactExists(string contact, int id = 0);
    }
}
