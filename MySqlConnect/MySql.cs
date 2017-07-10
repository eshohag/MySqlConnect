using MySql.Data.MySqlClient;

namespace MySqlConnect
{
    public abstract class MySql
    {
        public static MySqlConnection Connection(string serverName, string databaseName, string userId, string password)
        {
            string connectionString = "SERVER=" + serverName + ";" + "DATABASE=" + databaseName + ";" + "UID=" + userId + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

    }
}
