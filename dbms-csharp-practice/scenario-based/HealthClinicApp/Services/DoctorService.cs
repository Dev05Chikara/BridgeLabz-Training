using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class DoctorService
    {
        // UC-2.1 Add Doctor
        public void AddDoctor()
        {
            Console.Write("Doctor Name: ");
            string name = Console.ReadLine();

            Console.Write("Specialty ID: ");
            int specialtyId = int.Parse(Console.ReadLine());

            Console.Write("Contact: ");
            string contact = Console.ReadLine();

            Console.Write("Consultation Fee: ");
            decimal fee = decimal.Parse(Console.ReadLine());

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Doctors
                             (Name, SpecialtyId, Contact, ConsultationFee)
                             VALUES (@Name, @SpecialtyId, @Contact, @Fee)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@SpecialtyId", specialtyId);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Fee", fee);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Doctor Added Successfully.");
        }

        // UC-2.2 Update Doctor Specialty (Transaction)
        public void UpdateDoctorSpecialty()
        {
            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            Console.Write("New Specialty ID: ");
            int specialtyId = int.Parse(Console.ReadLine());

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                string query = @"UPDATE Doctors 
                                 SET SpecialtyId=@SpecialtyId
                                 WHERE DoctorId=@DoctorId";

                using var cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@SpecialtyId", specialtyId);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                cmd.ExecuteNonQuery();
                transaction.Commit();

                Console.WriteLine("Specialty Updated.");
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Update Failed.");
            }
        }

        // UC-2.3 View Doctors by Specialty (JOIN)
        public void ViewDoctorsBySpecialty()
        {
            Console.Write("Enter Specialty Name: ");
            string specialty = Console.ReadLine();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"SELECT d.DoctorId, d.Name, s.SpecialtyName, d.ConsultationFee
                             FROM Doctors d
                             INNER JOIN Specialties s 
                             ON d.SpecialtyId = s.SpecialtyId
                             WHERE s.SpecialtyName LIKE @Specialty
                             AND d.IsActive = 1";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Specialty", "%" + specialty + "%");

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["DoctorId"]} - {reader["Name"]} - {reader["SpecialtyName"]} - Fee: {reader["ConsultationFee"]}");
            }
        }

        // UC-2.4 Soft Delete Doctor
        public void DeactivateDoctor()
        {
            Console.Write("Doctor ID to Deactivate: ");
            int doctorId = int.Parse(Console.ReadLine());

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string checkQuery = @"SELECT COUNT(*) FROM Appointments
                                  WHERE DoctorId=@DoctorId
                                  AND AppointmentDate >= GETDATE()
                                  AND Status='SCHEDULED'";

            using var checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            int futureAppointments = (int)checkCmd.ExecuteScalar();

            if (futureAppointments > 0)
            {
                Console.WriteLine("Cannot deactivate. Future appointments exist.");
                return;
            }

            string query = @"UPDATE Doctors SET IsActive=0 WHERE DoctorId=@DoctorId";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DoctorId", doctorId);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Doctor Deactivated.");
        }
    }
}
