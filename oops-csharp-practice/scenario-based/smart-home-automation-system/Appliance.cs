using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class Appliance : IControllable
    {
        public string ApplianceName { get; set; }

        public virtual void TurnOn()
        {
            Console.WriteLine("Appliance is turned ON");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Appliance is turned OFF");
        }
    }
}

