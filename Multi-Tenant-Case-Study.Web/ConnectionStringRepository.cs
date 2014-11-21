using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Multi_Tenant_Case_Study.Web
{
    public class ConnectionStringRepository
    {
        public String Get(String host)
        {
            var sql = @"SELECT ConnectionString FROM Hosts WHERE Host = @Host";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hosts"].ConnectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@Host", host);

                    return (String)command.ExecuteScalar();
                }
            }
        }
    }
}