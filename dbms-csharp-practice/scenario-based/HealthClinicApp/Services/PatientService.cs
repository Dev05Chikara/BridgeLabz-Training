using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class PatientService
    {
        public void RegisterPatient()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string checkQuery = "SELECT COUNT(*) FROM Patients WHERE Phone=@Phone OR Email=@Email";
            using var checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@Phone", phone);
            checkCmd.Parameters.AddWithValue("@Email", email);

            int exists = (int)checkCmd.ExecuteScalar();
            if (exists > 0)
            {
                Console.WriteLine("Patient already exists.");
                return;
            }

            string query = @"INSERT INTO Patients(Name,DOB,Phone,Email)
                             VALUES(@Name,GETDATE(),@Phone,@Email)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Patient Registered Successfully.");
        }

        public void SearchPatient()
        {
            Console.Write("Enter name or phone: ");
            string keyword = Console.ReadLine();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"SELECT * FROM Patients 
                             WHERE Name LIKE @Name OR Phone=@Phone";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", "%" + keyword + "%");
            cmd.Parameters.AddWithValue("@Phone", keyword);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["PatientId"]} - {reader["Name"]} - {reader["Phone"]}");
            }
        }
    }
}
