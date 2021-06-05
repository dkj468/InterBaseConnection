using System.Data;
using System.Threading.Tasks;
using Dapper;
using Interbase_connection.Models;
using Microsoft.Extensions.Configuration;
using InterBaseSql.Data.InterBaseClient;
using System.Collections.Generic;

namespace Interbase_connection.Data
{
    public class Repository : IRepository
    {
        IConfiguration _config;
        public Repository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<List<WorkRequest>> GetAllWorkrequest()
        {
            using (var connection = new IBConnection(_config.GetConnectionString("DefaultConnectionString")))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //connection.Open();
                var list = await connection.QueryAsync<List<WorkRequest>>(@"SELECT * FROM AI_665");
                return list;
            }
        }
    }
}