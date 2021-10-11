using System;
namespace BlogRepo
{
    public class BaseRepository : DBConnection
    {
        private string _connectionString;

        public BaseRepository(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
