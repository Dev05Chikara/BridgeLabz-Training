using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal class OptimiseImpl : IStarategy
    {
        public int CalculateRevenue(Rod rod, PriceChart prices)
        {
            int n = rod.RodLength;
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;
                foreach (var p in prices.GetAll())
                {
                    if (p.Key <= i)
                    {
                        max = Math.Max(max, p.Value + dp[i - p.Key]);
                    }
                }
                dp[i] = max;
            }
            return dp[n];
        }

    }
}
