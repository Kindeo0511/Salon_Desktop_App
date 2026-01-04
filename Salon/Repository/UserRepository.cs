using Dapper;
using Laundry.Data;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        public int TotalUsers() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_users";
                return con.ExecuteScalar<int>(sql);
            }
        }
        public IEnumerable<UsersModel> GetAllUsers()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_users WHERE is_deactivate = 0";
                return con.Query<UsersModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<UsersModel>> GetAllCustomerAsync(int PageSize, int Offset) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT *
                        FROM tbl_users
                        WHERE is_deactivate = 0
                        ORDER BY user_id
                        LIMIT @PageSize OFFSET @Offset;";
                var result =  await con.QueryAsync<UsersModel>(sql, new { PageSize, Offset});
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
        public int AddUser(UsersModel user)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_users (first_Name, middle_Name, last_Name, birth_date, phone_Number, email, address,userName, userPassword, Position) 
                            VALUES (@first_Name, @middle_Name, @last_Name, @birth_date, @phone_Number, @email, @address, @userName, @userPassword, @Position);
                            SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, user);
            }
        }
        public int UpdateUser(UsersModel user)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_users SET first_Name = @first_Name, middle_Name = @middle_Name, last_Name = @last_Name, 
                            birth_date = @birth_date, phone_Number = @phone_Number, email = @email, address = @address, 
                             WHERE user_id = @user_id";
                return con.Execute(sql, user);
            }
        }
        public void UpdateUserAccount(UsersModel user)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_users SET Position = @Position, userName = @userName, userPassword = @userPassword WHERE user_id = @user_id";
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
        public int DeleteUser(int userId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_users SET status = 'Inactive', is_deactivate = 1 WHERE user_id = @userId";
                return con.Execute(sql, new { userId });
            }
        }
        public void PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM  tbl_users WHERE user_id = @id";
                con.Execute(sql, new { id });
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
                var sql = "SELECT COUNT(*) FROM tbl_users WHERE email = @email AND user_id != @id AND is_deactivate = 0";
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


        public UsersModel GetEmailAccount(string email)
        {
            using (var con = Database.GetConnection())
            {
                string sql = @"SELECT user_id, userName, email, is_deactivate
                       FROM tbl_users
                       WHERE email = @email
                       LIMIT 1";

                return con.QueryFirstOrDefault<UsersModel>(sql, new { email });
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

        public int RestoreUserAccount(int user_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_users SET status = 'Active', is_deactivate = 0 WHERE user_id = @user_id";
                return con.Execute(sql, new { user_id });
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

        public int UserAccountExists() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_users )   
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql);
            }
        }



    }
}
