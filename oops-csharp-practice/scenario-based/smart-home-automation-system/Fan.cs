using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is rotating at medium speed 🌀");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Fan is stopped");
        }
    }
}
