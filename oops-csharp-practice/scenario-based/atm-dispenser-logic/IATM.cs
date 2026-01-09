using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.atm_dispenser_logic
{
    internal interface IATM
    {
        void DispenseAmount(int amount);
        void RemoveFiveHundredNote();
    }
}
