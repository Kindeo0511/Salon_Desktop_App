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

        public bool CheckAdminExists() 
        {
            return _repo.IsAdminExists();
        }
        public IEnumerable<UsersModel> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }
        public UsersModel GetUser(string email) 
        {
            return _repo.GetUserByEmail(email);
        }

        public async Task<IEnumerable<UsersModel>> RefreshUsers() 
        {
            return await _repo.GetAllCustomerAsync();
        }
        public UsersModel GetUserByPhone(string phone)
        {
            return _repo.GetUserByContactNumber(phone);
        }
        public UsersModel GetUserAndPass(string user, string pass) 
        {
            return _repo.GetUserAndPassword(user, pass);
        }
        public int AddUser(UsersModel user)
        {
            return _repo.AddUser(user);
        }
        public bool UpdateUser(UsersModel user)
        {
            return _repo.UpdateUser(user) > 0;
        }
        public void UpdateUserAccount(UsersModel user) 
        {
            _repo.UpdateUserAccount(user);
        }

        public void UpdateUserByOtp(UsersModel user) 
        {
            _repo.UpdateUserByEmailOrPhone(user);
        }
        public bool DeleteUser(int userId)
        {
            return _repo.DeleteUser(userId) > 0;
        }
        public void DeletePermanent(int id) 
        {
            _repo.PermanentDelete(id);
        }

        public bool GetUserExistsAsync(string username, int id = 0) 
        {
            return  _repo.UserExistsAsync(username, id);
        }

        public  bool GetUserEmailExistsAsync(string email, int id = 0)
        {
            return  _repo.UserEmailExistsAsync(email, id);
        }

        public  bool GetUserNumberExistsAsync(string number, int id = 0)
        {
            return  _repo.UserNumberExistsAsync(number, id);
        }

        public UsersModel UserAccountExistsByEmail(string email) 
        {
            return _repo.GetEmailAccount(email);
        }
        public int RestoreUserAccount(int id) 
        {
            return _repo.RestoreUserAccount(id);
        }
        public UsersModel AuthenticateUser(string username, string password)
        {
            return _repo.LoginUser(username, password);
        }

        public bool IsUserAccountExists()
        {
            return _repo.UserAccountExists() > 0;
        }

        // RESTORE DATA

        public void RestoreUser(int userId) 
        {
            _repo.RestoreUser(userId);
        }
    }
}
