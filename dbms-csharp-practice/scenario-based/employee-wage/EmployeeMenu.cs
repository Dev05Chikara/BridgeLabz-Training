using System;

internal class EmployeeMenu
{
    private IEmployee employeeUtility;

    public EmployeeMenu()
    {
        employeeUtility = new EmployeeUtilityImpl();
    }

    public void DisplayMenu()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.WriteLine("\n===== Employee Wage Computation Menu =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Check Attendance");
            Console.WriteLine("4. Calculate Daily Wage");
            Console.WriteLine("5. Calculate Part Time Wage");
            Console.WriteLine("6. Wage Using Switch Case");
            Console.WriteLine("7. Calculate Monthly Wage");
            Console.WriteLine("8. Wage Till Condition");
            Console.WriteLine("9. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: employeeUtility.AddEmployee(); break;
                case 2: employeeUtility.ViewEmployees(); break;
                case 3: employeeUtility.CheckEmployeeAttendance(); break;
                case 4: employeeUtility.CalculateDailyWage(); break;
                case 5: employeeUtility.CalculatePartTimeWage(); break;
                case 6: employeeUtility.CalculateWageUsingSwitchCase(); break;
                case 7: employeeUtility.CalculateMonthlyWage(); break;
                case 8: employeeUtility.CalculateWageTillCondition(); break;
                case 9: continueMenu = false; break;
                default: Console.WriteLine("Invalid Choice!"); break;
            }
        }
    }
}
