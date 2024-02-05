using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDesktop.DatabaseConnection
{
    internal class PostgresConnection
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=supermarket_DB;";
        public static NpgsqlConnection GetConnection () 
        {
            return new NpgsqlConnection (connectionString);
        }
    }
}
