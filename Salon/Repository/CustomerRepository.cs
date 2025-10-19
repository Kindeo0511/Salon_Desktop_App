using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Salon.Repository
{
    public  class CustomerRepository : ICustomer
    {
        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            using (var con = Database.GetConnection()) 
            {
            
                var sql = "SELECT * FROM tbl_customer_account WHERE is_deleted = 0";
                return con.Query<CustomerModel>(sql).ToList();
            }
        }
        public CustomerModel TotalCustomer() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) AS TotalCustomer FROM tbl_customer_account";

                return con.Query<CustomerModel>(sql).FirstOrDefault();
            }
        }
        public CustomerModel GetCustomerById(int id) 
        {
            using (var con = Database.GetConnection())
            {

                var sql = "SELECT * FROM tbl_customer_account WHERE customer_id = @id";
                return con.Query<CustomerModel>(sql, new {id = id }).FirstOrDefault();
            }
        }
        public List<CustomerModel> GetCustomerBySearch(string key)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_customer_account WHERE firstName LIKE @Key OR middleName LIKE @Key OR lastName LIKE @Key OR email LIKE @Key";
                return con.Query<CustomerModel>(sql, new { Key = $"%{key}%" }).ToList();
            }
        }
        public void AddCustomer(CustomerModel customer)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_customer_account (firstName, middleName, lastName, phoneNumber, email) VALUES (@firstName, @middleName, @lastName, @phoneNumber, @email)";
                con.Execute(sql, customer);
            }
        }
        public void UpdateCustomer(CustomerModel customer)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_customer_account SET firstName = @firstName, middleName = @middleName, lastName = @lastName, phoneNumber = @phoneNumber, email = @email WHERE customer_id = @customer_id";
                con.Execute(sql, customer);
            }
        }
        public void DeleteCustomer(int customerId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_customer_account SET status = 'Inactive', is_deleted = 1 WHERE customer_id = @customerId";
                con.Execute(sql, new { customerId });
            }
        }

        public void ActivateCustomer(int customerId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_customer_account SET status = 'Active', is_deleted = 0 WHERE customer_id = @customerId";
                con.Execute(sql, new { customerId });
            }
        }
        public bool EmailExists(string email, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_customer_account WHERE email = @email AND customer_id != @id";
                
                return con.ExecuteScalar<int>(sql, new { email, id }) > 0;
            }
        }
        public bool ContactExists(string contact, int id = 0) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_customer_account WHERE phoneNumber = @contact AND customer_id != @id";

                return con.ExecuteScalar<int>(sql, new { contact, id }) > 0;
            }
        }



    }
}
