using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal class EmployeeMain
    {
        public static void Main(string[] args)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.DisplayMenu();
        }
    }
}