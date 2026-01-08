using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class ApplianceMain
    {
        public static void Main(string[] args)
        {
            ApplianceMenu menu = new ApplianceMenu();
            menu.DisplayMenu();
        }
    }
}
