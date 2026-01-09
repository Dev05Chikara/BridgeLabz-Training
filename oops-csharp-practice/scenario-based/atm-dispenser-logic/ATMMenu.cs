using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.atm_dispenser_logic
{
    sealed class ATMMenu
    {
        private IATM atmUtility;

        public ATMMenu()
        {
            atmUtility = new ATMUtilityImpl();
        }

        public void DisplayMenu()
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("\n===== ATM Dispenser Menu =====");
                Console.WriteLine("1. Dispense ₹880");
                Console.WriteLine("2. Remove ₹500 Note");
                Console.WriteLine("3. Dispense Custom Amount");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        atmUtility.DispenseAmount(880);
                        break;

                    case 2:
                        atmUtility.RemoveFiveHundredNote();
                        break;

                    case 3:
                        Console.Write("Enter amount: ");
                        int amount = int.Parse(Console.ReadLine());
                        atmUtility.DispenseAmount(amount);
                        break;

                    case 4:
                        continueMenu = false;
                        Console.WriteLine("Exiting ATM...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
