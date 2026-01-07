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
    }
}
