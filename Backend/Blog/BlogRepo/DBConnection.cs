using System;
using System.Data.SqlClient;

namespace BlogRepo
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection NewSqlConnection()
        {
            return new SqlConnection
            {
                ConnectionString = _connectionString
            };
        }
    }
}
