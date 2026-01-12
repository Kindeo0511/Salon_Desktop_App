using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IUser
    {
        bool IsAdminExists();
        IEnumerable<UsersModel> GetAllUsers();

        Task<IEnumerable<UsersModel>> GetAllCustomerAsync(int PageSize, int Offset);
        UsersModel GetUserByEmail(string name);
        UsersModel GetUserByContactNumber(string number);
        UsersModel GetUserAndPassword(string user, string pass);
        int AddUser(UsersModel user);
        int UpdateUser(UsersModel user);

        void UpdateUserAccount(UsersModel user);

        void UpdateUserByEmailOrPhone(UsersModel user);
        int DeleteUser(int userId);
        int PermanentDelete(int id);
        bool UserExistsAsync(string username, int id = 0);
        bool UserEmailExistsAsync(string email, int id = 0);
        bool UserNumberExistsAsync(string number, int id = 0);


        // LOGIN USER
        UsersModel LoginUser(string username, string password);
        UsersModel GetUserByUsername(string username);

        // RESTORING DATA

        void RestoreUser(int userId);
    }
}
