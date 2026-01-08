using System;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[10];
        private int employeeCount = 0;
        private Random random;

        public EmployeeUtilityImpl()
        {
            random = new Random();
        }

        // Check employee added or not
        private bool IsEmployeeAdded()
        {
            if (employeeCount == 0)
            {
                Console.WriteLine("Error: Employee not added. Please add employee first.");
                return false;
            }
            return true;
        }

        // UC0 - Add Employee
        public Employee AddEmployee()
        {
            if (employeeCount >= employees.Length)
            {
                Console.WriteLine("Employee limit reached.");
                return null;
            }

            Employee employee = new Employee();
            employees[employeeCount++] = employee;
            Console.WriteLine("Employee added successfully.");

            return employee;
        }

        // UC1 - Check Employee Attendance
        public bool CheckEmployeeAttendance()
        {
            if (!IsEmployeeAdded())
                return false;

            int attendance = random.Next(0, 2);

            if (attendance == Employee.IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                return true;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                return false;
            }
        }

        // UC2 - Calculate Daily Wage
        public double CalculateDailyWage()
        {
            if (!IsEmployeeAdded())
                return 0;

            bool isPresent = CheckEmployeeAttendance();
            double dailyWage = 0;

            if (isPresent)
            {
                dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
            }

            Console.WriteLine($"Daily Wage: {dailyWage}");
            return dailyWage;
        }

        // UC3 - Calculate Part Time Wage
        public double CalculatePartTimeWage()
        {
            if (!IsEmployeeAdded())
                return 0;

            double wage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
            Console.WriteLine($"Part Time Wage: {wage}");
            return wage;
        }

        // UC4 - Wage using Switch Case
        public double CalculateWageUsingSwitchCase()
        {
            if (!IsEmployeeAdded())
                return 0;

            int empType = random.Next(0, 3);
            double dailyWage = 0;

            switch (empType)
            {
                case Employee.IS_ABSENT:
                    Console.WriteLine("Employee is Absent");
                    break;

                case Employee.IS_PRESENT:
                    Console.WriteLine("Employee is Present (Full Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                    break;

                case Employee.IS_PART_TIME:
                    Console.WriteLine("Employee is Present (Part Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                    break;
            }

            Console.WriteLine($"Daily Wage: {dailyWage}");
            return dailyWage;
        }

        // UC5 - Calculate Monthly Wage
        public double CalculateMonthlyWage()
        {
            if (!IsEmployeeAdded())
                return 0;

            double monthlyWage = 0;

            for (int day = 1; day <= Employee.WORKING_DAYS_PER_MONTH; day++)
            {
                int empType = random.Next(0, 3);
                double dailyWage = 0;

                switch (empType)
                {
                    case Employee.IS_PRESENT:
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                        break;

                    case Employee.IS_PART_TIME:
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                        break;
                }

                monthlyWage += dailyWage;
                Console.WriteLine($"Day {day}: Wage = {dailyWage}");
            }

            Console.WriteLine($"Total Monthly Wage: {monthlyWage}");
            return monthlyWage;
        }

        // UC6 - Calculate Wage Till Condition
        public double CalculateWageTillCondition()
        {
            if (!IsEmployeeAdded())
                return 0;

            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            double totalWage = 0;

            while (totalWorkingHours < Employee.MAX_WORKING_HOURS &&
                   totalWorkingDays < Employee.MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empType = random.Next(0, 3);

                int hoursWorked = 0;
                double dailyWage = 0;

                switch (empType)
                {
                    case Employee.IS_PRESENT:
                        hoursWorked = Employee.FULL_DAY_HOUR;
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                        break;

                    case Employee.IS_PART_TIME:
                        hoursWorked = Employee.PART_TIME_HOUR;
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                        break;
                }

                totalWorkingHours += hoursWorked;
                totalWage += dailyWage;

                Console.WriteLine(
                    $"Day {totalWorkingDays}: Hours={hoursWorked}, Wage={dailyWage}"
                );
            }

            Console.WriteLine($"Total Working Days: {totalWorkingDays}");
            Console.WriteLine($"Total Working Hours: {totalWorkingHours}");
            Console.WriteLine($"Total Wage: {totalWage}");

            return totalWage;
        }
    }
}