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
        IEnumerable<UsersModel> GetAllUsers();

        UsersModel GetUserAndPassword(string user, string pass);
        void AddUser(UsersModel user);
        void UpdateUser(UsersModel user);
        void DeleteUser(int userId);
    }
}
