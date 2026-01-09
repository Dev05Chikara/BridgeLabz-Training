using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.atm_dispenser_logic
{
    internal class ATMUtilityImpl : IATM
    {
        private ATM atm;

        public ATMUtilityImpl()
        {
            atm = new ATM();
        }

        // Scenario A & C
        public void DispenseAmount(int amount)
        {
            int remainingAmount = amount;
            Console.WriteLine($"\nDispensing ₹{amount}");

            foreach (int note in atm.notes)
            {
                int count = remainingAmount / note;

                if (count > 0)
                {
                    Console.WriteLine($"₹{note} x {count}");
                    remainingAmount %= note;
                }
            }

            if (remainingAmount != 0)
            {
                Console.WriteLine($"Fallback: Remaining ₹{remainingAmount} cannot be dispensed exactly");
            }
            else
            {
                Console.WriteLine("Amount dispensed successfully");
            }
        }

        // Scenario B
        public void RemoveFiveHundredNote()
        {
            atm.notes = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("₹500 note temporarily removed");
        }
    }
}
