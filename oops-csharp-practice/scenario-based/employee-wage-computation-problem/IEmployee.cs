using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal interface IEmployee
    {
        // abstract Method
        Employee AddEmployee();

        // UC1 - Check Employee Attendance
        bool CheckEmployeeAttendance();

        // UC2 - Calculate Daily Employee Wage
        double CalculateDailyWage();

        // UC3 - Calculate Part Time Wage
        double CalculatePartTimeWage();

        // UC4 - Calculate Wage Using Switch Case
        double CalculateWageUsingSwitchCase();
    }
}
