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
    }
}