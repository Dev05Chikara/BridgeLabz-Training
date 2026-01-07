using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private Random random;

        public EmployeeUtilityImpl()
        {
            random = new Random();
        }

        // Logic
        public Employee AddEmployee()
        {
            employee = new Employee();
            return employee;
        }

        // UC1 - Check Employee is Present or Absent
        public bool CheckEmployeeAttendance()
        {
            int attendance = random.Next(0, 2); // Generates 0 or 1
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

        // UC2 - Calculate Daily Employee Wage
        public double CalculateDailyWage()
        {
            bool isPresent = CheckEmployeeAttendance();
            double dailyWage = 0;

            if (isPresent)
            {
                dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                Console.WriteLine($"Daily Wage: {dailyWage}");
            }
            else
            {
                Console.WriteLine("Daily Wage: 0 (Employee Absent)");
            }

            return dailyWage;
        }

        // UC3 - Add Part Time Employee & Wage
        public double CalculatePartTimeWage()
        {
            double wage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
            Console.WriteLine($"Part Time Wage: {wage}");
            return wage;
        }

        // UC4 - Solving using Switch Case Statement
        public double CalculateWageUsingSwitchCase()
        {
            int empType = random.Next(0, 3); // 0: Absent, 1: Full Time, 2: Part Time
            double dailyWage = 0;

            switch (empType)
            {
                case Employee.IS_ABSENT:
                    Console.WriteLine("Employee is Absent");
                    dailyWage = 0;
                    break;
                case Employee.IS_PRESENT:
                    Console.WriteLine("Employee is Present (Full Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                    break;
                case Employee.IS_PART_TIME:
                    Console.WriteLine("Employee is Present (Part Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                    break;
                default:
                    Console.WriteLine("Invalid Employee Type");
                    break;
            }

            Console.WriteLine($"Daily Wage: {dailyWage}");
            return dailyWage;
        }

        // UC5 - Calculating Wages for a Month
        public double CalculateMonthlyWage()
        {
            double monthlyWage = 0;

            for (int day = 1; day <= Employee.WORKING_DAYS_PER_MONTH; day++)
            {
                int empType = random.Next(0, 3);
                double dailyWage = 0;

                switch (empType)
                {
                    case Employee.IS_ABSENT:
                        dailyWage = 0;
                        break;
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
    }
}