using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dapper.DAO
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DapperASPNetCore;Trusted_Connection=True;MultipleActiveResultSets=true;";
            _configuration.GetConnectionString(_connectionString);
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}