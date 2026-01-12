using BridgeLabzTraining.senariobased.metal_factory_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal class WasteConstraintImpl : IStarategy, IWasteAware
    {
        private int maxWasteAllowed;
        private Dictionary<int, List<int>> cutDetails = new Dictionary<int, List<int>>();

        public WasteConstraintImpl(int maxWaste)
        {
            maxWasteAllowed = maxWaste;
        }

        public int CalculateRevenue(Rod rod, PriceChart prices)
        {
            int n = rod.RodLength;
            int[] dp = new int[n + 1];
            int[] cuts = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;
                int bestCut = 0;

                // Only consider cuts that keep waste within constraint
                int minAcceptableLength = Math.Max(1, i - maxWasteAllowed);

                foreach (var p in prices.GetAll())
                {
                    if (p.Key <= i && p.Key >= minAcceptableLength)
                    {
                        int currentValue = p.Value + dp[i - p.Key];
                        if (currentValue > max)
                        {
                            max = currentValue;
                            bestCut = p.Key;
                        }
                    }
                }

                dp[i] = max;
                cuts[i] = bestCut > 0 ? bestCut : i;
            }

            // Store cut details
            List<int> cutList = new List<int>();
            int remaining = n;
            while (remaining > 0)
            {
                cutList.Add(cuts[remaining]);
                remaining -= cuts[remaining];
            }
            cutDetails[n] = cutList;

            int waste = n - cutList.Sum();
            Console.WriteLine($"Cuts with max {maxWasteAllowed}ft waste: {string.Join(" + ", cutList)}ft");
            Console.WriteLine($"Actual waste: {waste}ft (within {maxWasteAllowed}ft limit)");

            return dp[n];
        }

        public int CalculateWaste(Rod rod, PriceChart prices)
        {
            if (!cutDetails.ContainsKey(rod.RodLength))
            {
                CalculateRevenue(rod, prices);
            }
            return rod.RodLength - cutDetails[rod.RodLength].Sum();
        }

        public List<int> GetCutLengths(Rod rod, PriceChart prices)
        {
            if (!cutDetails.ContainsKey(rod.RodLength))
            {
                CalculateRevenue(rod, prices);
            }
            return cutDetails[rod.RodLength];
        }
    }
}
