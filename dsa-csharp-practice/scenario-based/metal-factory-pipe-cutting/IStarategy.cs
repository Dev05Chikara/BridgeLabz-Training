using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal interface IStarategy
    {
        int CalculateRevenue(Rod rod, PriceChart prices);
    }
}
