using MySql.Data.MySqlClient;

namespace Laundry.Data
{
    public static class Database
    {
        public static string connection = "server=localhost;userid=root;password=;database=hcsansor";
        //public static string connection = "server=192.168.1.23;userid=remote_user;password=;database=hcsansor";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connection);
        }
    }
}
