using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class AppointmentService
    {
        public void BookAppointment()
        {
            Console.Write("Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                string insertQuery = @"INSERT INTO Appointments
                (PatientId, DoctorId, AppointmentDate, AppointmentTime)
                VALUES (@PatientId, @DoctorId, GETDATE(), GETDATE())";

                using var cmd = new SqlCommand(insertQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                cmd.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Appointment Booked.");
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Booking Failed.");
            }
        }
    }
}
