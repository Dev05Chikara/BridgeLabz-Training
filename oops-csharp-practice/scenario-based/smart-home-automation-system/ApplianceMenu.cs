using BridgeLabzTraining.senariobased.employee_wage_computation_problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    sealed class ApplianceMenu
    {
        private ApplianceUtility utility;

        public ApplianceMenu()
        {
            utility = new ApplianceUtility();
        }

        public void DisplayMenu()
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("\n===== Smart Home Automation Menu =====");
                Console.WriteLine("1. Select Light");
                Console.WriteLine("2. Select Fan");
                Console.WriteLine("3. Select AC");
                Console.WriteLine("4. Turn ON Appliance");
                Console.WriteLine("5. Turn OFF Appliance");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        utility.SelectAppliance(choice);
                        break;

                    case 4:
                        utility.TurnOnAppliance();
                        break;

                    case 5:
                        utility.TurnOffAppliance();
                        break;

                    case 6:
                        continueMenu = false;
                        Console.WriteLine("Exiting Smart Home System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
