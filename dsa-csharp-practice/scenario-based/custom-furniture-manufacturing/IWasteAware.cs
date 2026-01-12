using BridgeLabzTraining.senariobased.metal_factory_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal interface IWasteAware
    {
        int CalculateWaste(Rod rod, PriceChart prices);
        List<int> GetCutLengths(Rod rod, PriceChart prices);
    }
}
