using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal class FactoryShow
    {
        public static void Show(IStarategy starategy, PriceChart prices, Rod rod)
        {
            Console.WriteLine(starategy.CalculateRevenue(rod, prices));
        }
    }
}
