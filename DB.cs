using System;
using MySql.Data.MySqlClient;

namespace GymAppSQL
{
    internal class DB : IDisposable
    {
        private MySqlConnection connection;

        public DB()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=gymappsql";
            connection = new MySqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
