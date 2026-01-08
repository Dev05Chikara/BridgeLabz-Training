using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class Ac : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("AC is cooling the room ❄️");
        }

        public override void TurnOff()
        {
            Console.WriteLine("AC is turned OFF");
        }
    }
}
