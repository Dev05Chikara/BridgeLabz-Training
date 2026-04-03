using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class BillingService
    {
        public void GenerateRevenueReport()
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"SELECT SUM(TotalAmount) FROM Bills
                             WHERE PaymentStatus='PAID'";

            using var cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteScalar();

            Console.WriteLine($"Total Revenue: {result}");
        }
    }
}
