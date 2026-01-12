using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal class NonOptimiseImpl : IStarategy
    {
        public int CalculateRevenue(Rod rod, PriceChart prices)
        {
            return prices.GetPrice(rod.RodLength);
        }
    }
}
