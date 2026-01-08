using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.smart_home_automation_system
{
    internal class LightBulb : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Light Bulb is glowing softly 💡");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Light Bulb is switched OFF");
        }
    }
}

