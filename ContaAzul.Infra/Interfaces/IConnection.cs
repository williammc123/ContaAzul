using System.Data.SqlClient;

namespace ContaAzul.Infra.Connection
{
    interface IConnection
    {
        SqlConnection sqlConnection();
    }
}
