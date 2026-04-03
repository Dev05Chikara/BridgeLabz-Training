using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Data
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
