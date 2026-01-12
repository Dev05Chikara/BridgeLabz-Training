using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal interface IStarategy
    {
        int CalculateRevenue(Rod rod, PriceChart prices);
    }
}
