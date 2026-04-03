using HealthClinicApp.Services;

namespace HealthClinicApp.UI
{
    public class MainMenu
    {
        private readonly PatientService patientService = new PatientService();
        private readonly AppointmentService appointmentService = new AppointmentService();
        private readonly VisitService visitService = new VisitService();
        private readonly BillingService billingService = new BillingService();
        private readonly DoctorService doctorService = new DoctorService();

        public void Start()
        {
            int mainChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("===== HEALTH CLINIC MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Patient Operations");
                Console.WriteLine("2. Doctor Operations");
                Console.WriteLine("0. Exit");
                Console.Write("Select Option: ");

                if (!int.TryParse(Console.ReadLine(), out mainChoice))
                {
                    Console.WriteLine("Invalid input.");
                    ContinuePrompt();
                    continue;
                }

                switch (mainChoice)
                {
                    case 1:
                        PatientMenu();
                        break;

                    case 2:
                        DoctorMenu();
                        break;

                    case 0:
                        Console.WriteLine("Exiting System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        ContinuePrompt();
                        break;
                }

            } while (mainChoice != 0);
        }

        private void PatientMenu()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("===== PATIENT OPERATIONS =====");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Book Appointment");
                Console.WriteLine("4. Record Visit");
                Console.WriteLine("5. Generate Revenue Report");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select Option: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    ContinuePrompt();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        patientService.RegisterPatient();
                        break;

                    case 2:
                        patientService.SearchPatient();
                        break;

                    case 3:
                        appointmentService.BookAppointment();
                        break;

                    case 4:
                        visitService.RecordVisit();
                        break;

                    case 5:
                        billingService.GenerateRevenueReport();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                ContinuePrompt();

            } while (choice != 0);
        }

        private void DoctorMenu()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("===== DOCTOR OPERATIONS =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Update Doctor Specialty");
                Console.WriteLine("3. View Doctors by Specialty");
                Console.WriteLine("4. Deactivate Doctor");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select Option: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    ContinuePrompt();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        doctorService.AddDoctor();
                        break;

                    case 2:
                        doctorService.UpdateDoctorSpecialty();
                        break;

                    case 3:
                        doctorService.ViewDoctorsBySpecialty();
                        break;

                    case 4:
                        doctorService.DeactivateDoctor();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                ContinuePrompt();

            } while (choice != 0);
        }

        private void ContinuePrompt()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
