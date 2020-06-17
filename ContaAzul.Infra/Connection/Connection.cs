using System;
using System.Data.SqlClient;

namespace ContaAzul.Infra.Connection
{
    public class Connection : IConnection
    {
        public SqlConnection sqlConnection()
        {
            return new SqlConnection();
        }
    }
}
