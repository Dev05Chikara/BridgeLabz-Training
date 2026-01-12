using BridgeLabzTraining.senariobased.metal_factory_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal class MinimalWasteOptimisedImpl : IStarategy, IWasteAware
    {
        private Dictionary<int, List<int>> cutDetails = new Dictionary<int, List<int>>();

        public int CalculateRevenue(Rod rod, PriceChart prices)
        {
            int n = rod.RodLength;
            int[] dp = new int[n + 1];
            int[] cuts = new int[n + 1];
            int[] waste = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int maxRevenue = 0;
                int bestCut = 0;
                int minWaste = i;

                foreach (var p in prices.GetAll())
                {
                    if (p.Key <= i)
                    {
                        int currentRevenue = p.Value + dp[i - p.Key];
                        int currentWaste = waste[i - p.Key];

                        // Prioritize revenue, then minimize waste
                        if (currentRevenue > maxRevenue ||
                            (currentRevenue == maxRevenue && currentWaste < minWaste))
                        {
                            maxRevenue = currentRevenue;
                            bestCut = p.Key;
                            minWaste = currentWaste;
                        }
                    }
                }

                dp[i] = maxRevenue;
                cuts[i] = bestCut;
                waste[i] = minWaste;
            }

            // Store cut details
            List<int> cutList = new List<int>();
            int remaining = n;
            while (remaining > 0 && cuts[remaining] > 0)
            {
                cutList.Add(cuts[remaining]);
                remaining -= cuts[remaining];
            }
            cutDetails[n] = cutList;

            int totalWaste = remaining;
            Console.WriteLine($"Revenue-maximized cuts with minimal waste: {string.Join(" + ", cutList)}ft");
            Console.WriteLine($"Waste: {totalWaste}ft, Pieces: {cutList.Count}");

            return dp[n];
        }

        public int CalculateWaste(Rod rod, PriceChart prices)
        {
            if (!cutDetails.ContainsKey(rod.RodLength))
            {
                CalculateRevenue(rod, prices);
            }
            int totalCuts = cutDetails[rod.RodLength].Sum();
            return rod.RodLength - totalCuts;
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
