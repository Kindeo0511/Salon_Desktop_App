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
        UsersModel GetUserByEmail(string name);
        UsersModel GetUserByContactNumber(string number);
        UsersModel GetUserAndPassword(string user, string pass);
        void AddUser(UsersModel user);
        void UpdateUser(UsersModel user);

        void UpdateUserByEmailOrPhone(UsersModel user);
        void DeleteUser(int userId);

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
