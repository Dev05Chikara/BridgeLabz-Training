using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class ApplianceUtility
    {
        private Appliance appliance;

        public void SelectAppliance(int choice)
        {
            switch (choice)
            {
                case 1:
                    appliance = new LightBulb();
                    break;
                case 2:
                    appliance = new Fan();
                    break;
                case 3:
                    appliance = new Ac();
                    break;
                default:
                    Console.WriteLine("Invalid Appliance Choice");
                    appliance = null;
                    break;
            }
        }

        public void TurnOnAppliance()
        {
            if (appliance != null)
                appliance.TurnOn();
            else
                Console.WriteLine("Please select an appliance first");
        }

        public void TurnOffAppliance()
        {
            if (appliance != null)
                appliance.TurnOff();
            else
                Console.WriteLine("Please select an appliance first");
        }
    }
}
