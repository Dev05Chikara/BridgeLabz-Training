using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtility;

        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
            // Upcasting
        }

        public void DisplayMenu()
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("\n===== Employee Wage Computation Menu =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Employee Attendance");
                Console.WriteLine("3. Calculate Daily Wage");
                Console.WriteLine("4. Calculate Part Time Wage");
                Console.WriteLine("5. Calculate Wage Using Switch Case");
                Console.WriteLine("6. Calculate Monthly Wage");
                Console.WriteLine("7. Calculate Wage Till Condition");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = employeeUtility.AddEmployee();
                        Console.WriteLine("Employee Added Successfully!");
                        break;
                    case 2:
                        employeeUtility.CheckEmployeeAttendance();
                        break;
                    case 3:
                        employeeUtility.CalculateDailyWage();
                        break;
                    case 4:
                        employeeUtility.CalculatePartTimeWage();
                        break;
                    case 5:
                        employeeUtility.CalculateWageUsingSwitchCase();
                        break;
                    case 6:
                        employeeUtility.CalculateMonthlyWage();
                        break;
                    case 7:
                        employeeUtility.CalculateWageTillCondition();
                        break;
                    case 8:
                        continueMenu = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}