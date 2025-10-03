using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Salon.Controller
{
    public class UserController
    {
        private readonly UserRepository _repo;

        public UserController(UserRepository _repo)
        {
            this._repo = _repo;
        }

        public IEnumerable<UsersModel> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }

        public UsersModel GetUserAndPass(string user, string pass) 
        {
            return _repo.GetUserAndPassword(user, pass);
        }
        public void AddUser(UsersModel user)
        {
            _repo.AddUser(user);
        }
        public void UpdateUser(UsersModel user)
        {
            _repo.UpdateUser(user);
        }
        public void DeleteUser(int userId)
        {
            _repo.DeleteUser(userId);
        }
    }
}
