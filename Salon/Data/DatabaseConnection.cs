using MySql.Data.MySqlClient;
namespace Laundry.Data
{
    internal class DatabaseConnection
    {
        private string connectionString = "server=localhost;userid=root;password=;database=hcsansor";

        private MySqlConnection connection;

        // Constructor
        public DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Method to get the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

