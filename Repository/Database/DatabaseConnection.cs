using System.Data.SqlClient;

namespace Repository.Database
{
    public class DatabaseConnection
    {
        private static string connectionString = @"Server=mssql.fhict.local;Database=dbi369682;User Id=dbi369682;Password=liveperformance;";

        public SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}