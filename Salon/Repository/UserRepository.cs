using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Salon.Repository
{
    public class UserRepository : IUser
    {
        public bool IsAdminExists() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_users WHERE Position = 'Admin'";
                return con.ExecuteScalar<int>(sql) > 0;
            }
        }
        public IEnumerable<UsersModel> GetAllUsers()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_users";
                return con.Query<UsersModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<UsersModel>> GetAllCustomerAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_users";
                var result =  await con.QueryAsync<UsersModel>(sql);
                return result.ToList();
            }

        }
        public UsersModel GetUserByEmail(string email) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_users WHERE email = @email";
                return con.QueryFirstOrDefault<UsersModel>(sql, new { email });

            }
        }
        public UsersModel GetUserByContactNumber(string phone) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_users WHERE phone_Number = @phone";
                return con.QueryFirstOrDefault<UsersModel>(sql, new { phone });

            }
        }
        public UsersModel GetUserAndPassword(string user, string pass)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_users WHERE userName = @userName AND userPassword =@userPassword";
                return con.Query<UsersModel>(sql, new {userName = user, userPassword = pass }).FirstOrDefault();
            }
        }
        public void AddUser(UsersModel user)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_users (first_Name, middle_Name, last_Name, birth_date, phone_Number, email, address, userName, userPassword, Position) 
                            VALUES (@first_Name, @middle_Name, @last_Name, @birth_date, @phone_Number, @email, @address, @userName, @userPassword, @Position)";
                con.Execute(sql, user);
            }
        }
        public void UpdateUser(UsersModel user)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_users SET first_Name = @first_Name, middle_Name = @middle_Name, last_Name = @last_Name, 
                            birth_date = @birth_date, phone_Number = @phone_Number, email = @email, address = @address, 
                            userName = @userName, userPassword = @userPassword, Position = @Position WHERE user_id = @user_id";
                con.Execute(sql, user);
            }
        }

        public void UpdateUserByEmailOrPhone(UsersModel user) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_users SET userPassword = @userPassword WHERE email = @email OR phone_Number = @phone_Number";
                con.Execute(sql, user);
            }
        }
        public void DeleteUser(int userId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_users SET status = 'Inactive', is_deactivate = 1 WHERE user_id = @userId";
                con.Execute(sql, new { userId });
            }
        }

        public bool UserExistsAsync(string username, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_users WHERE userName = @username AND user_id != @id";
                var count =  con.ExecuteScalar<int>(sql, new { username, id });
                return count > 0;
            }
        }

        public  bool UserEmailExistsAsync(string email, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_users WHERE email = @email AND user_id != @id";
                var count =  con.ExecuteScalar<int>(sql, new { email, id });
                return count > 0;
            }
        }

        public  bool UserNumberExistsAsync(string number, int id = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_users WHERE phone_Number = @number AND user_id != @id";
                var count =  con.ExecuteScalar<int>(sql, new { number, id });
                return count > 0;
            }
        }

        public void RestoreUser(int userId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_users SET status = 'Active', is_deactivate = 0 WHERE user_id = @userId";
                con.Execute(sql, new { userId });
            }
        }

        public UsersModel LoginUser(string username, string password)
        {
            var user = GetUserByUsername(username);
            if (user == null || string.IsNullOrWhiteSpace(user.userPassword))
                return null;

            bool isValid = BCrypt.Net.BCrypt.Verify(password, user.userPassword);
            return isValid ? user : null;
        }

        public UsersModel GetUserByUsername(string username)
        {
            using (var con = Database.GetConnection())
            {
                string query = "SELECT * FROM tbl_users WHERE userName = @Username";
                return con.QueryFirstOrDefault<UsersModel>(query, new { Username = username });
            }

        }



    }
}
