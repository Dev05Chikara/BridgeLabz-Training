using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class VisitService
    {
        public void RecordVisit()
        {
            Console.Write("Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                string visitQuery = @"INSERT INTO Visits(AppointmentId, Diagnosis)
                                      VALUES(@AppointmentId,'General Checkup');
                                      SELECT SCOPE_IDENTITY();";

                using var cmd = new SqlCommand(visitQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                int visitId = Convert.ToInt32(cmd.ExecuteScalar());

                // Batch insert prescription
                string presQuery = @"INSERT INTO Prescriptions
                                     (VisitId, MedicineName, Dosage, Duration)
                                     VALUES(@VisitId,@Med,@Dos,@Dur)";

                for (int i = 0; i < 2; i++)
                {
                    using var presCmd = new SqlCommand(presQuery, conn, transaction);
                    presCmd.Parameters.AddWithValue("@VisitId", visitId);
                    presCmd.Parameters.AddWithValue("@Med", "Medicine" + i);
                    presCmd.Parameters.AddWithValue("@Dos", "1 Tablet");
                    presCmd.Parameters.AddWithValue("@Dur", "5 Days");
                    presCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                Console.WriteLine("Visit Recorded.");
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error Recording Visit.");
            }
        }
    }
}
