using Microsoft.Data.SqlClient;

internal class DBConnection
{
    private static string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=EmployeeWageDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
