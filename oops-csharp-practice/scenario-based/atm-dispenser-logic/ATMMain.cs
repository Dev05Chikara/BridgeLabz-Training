using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.atm_dispenser_logic
{
    internal class ATMMain
    {
        public static void Main(string[] args)
        {
            ATMMenu menu = new ATMMenu();
            menu.DisplayMenu();
        }
    }
}
