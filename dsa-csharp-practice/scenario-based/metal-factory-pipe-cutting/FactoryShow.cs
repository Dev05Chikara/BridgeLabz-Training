using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal class FactoryShow
    {
        public static void Show(IStarategy starategy, PriceChart prices, Rod rod)
        {
            Console.WriteLine(starategy.CalculateRevenue(rod, prices));
        }
    }
}
