using MySql.Data.MySqlClient;

namespace Laundry.Data
{
    public static class Database
    {
        public static string connection = "server=localhost;userid=root;password=;database=hcsansor";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connection);
        }
    }
}
