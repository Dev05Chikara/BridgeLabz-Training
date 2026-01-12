using BridgeLabzTraining.senariobased.metal_factory_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.custom_furniture_manufacturing
{
    internal class FurnitureScenario
    {
        public static void Main(string[] args)
        {
            // Scenario A: Determine best cut to maximize earnings for 12ft rod
            Console.WriteLine("=== SCENARIO A: Maximize Earnings for 12ft Rod ===");
            Rod rod12ft = new Rod(12);
            PriceChart furniturePrice = new PriceChart();

            // Furniture pricing (in dollars per foot)
            furniturePrice.AddPrice(1, 2);
            furniturePrice.AddPrice(2, 5);
            furniturePrice.AddPrice(3, 9);
            furniturePrice.AddPrice(4, 14);
            furniturePrice.AddPrice(5, 17);
            furniturePrice.AddPrice(6, 24);
            furniturePrice.AddPrice(7, 28);
            furniturePrice.AddPrice(8, 33);
            furniturePrice.AddPrice(9, 35);
            furniturePrice.AddPrice(10, 38);
            furniturePrice.AddPrice(11, 40);
            furniturePrice.AddPrice(12, 45);

            IStarategy optimisedStrategy = new OptimiseImpl();
            FactoryShow.Show(optimisedStrategy, furniturePrice, rod12ft);
            Console.WriteLine();

            // Scenario B: Fixed waste constraint (max 2ft waste allowed)
            Console.WriteLine("=== SCENARIO B: With Waste Constraint (Max 2ft) ===");
            IStarategy wasteConstraintStrategy = new WasteConstraintImpl(2);
            FactoryShow.Show(wasteConstraintStrategy, furniturePrice, rod12ft);
            Console.WriteLine();

            // Scenario C: Minimize waste while maximizing revenue
            Console.WriteLine("=== SCENARIO C: Maximize Revenue + Minimize Waste ===");
            IStarategy minimalWasteStrategy = new MinimalWasteOptimisedImpl();
            FactoryShow.Show(minimalWasteStrategy, furniturePrice, rod12ft);
            Console.WriteLine();

            // Comparison view
            Console.WriteLine("=== COMPARISON ===");
            Console.WriteLine("Strategy                    | Revenue | Waste");
            Console.WriteLine("------------------------------------------");

            var strategies = new Dictionary<string, IStarategy>
            {
                { "No Optimization          ", new NonOptimiseImpl() },
                { "Waste Constraint (2ft)   ", new WasteConstraintImpl(2) },
                { "Minimal Waste Optimized  ", new MinimalWasteOptimisedImpl() }
            };

            foreach (var strategy in strategies)
            {
                int revenue = strategy.Value.CalculateRevenue(rod12ft, furniturePrice);
                Console.WriteLine($"{strategy.Key} | ${revenue,6} | {GetWasteInfo(strategy.Value, rod12ft, furniturePrice)}");
            }
        }

        private static string GetWasteInfo(IStarategy strategy, Rod rod, PriceChart prices)
        {
            if (strategy is IWasteAware wasteAware)
            {
                int waste = wasteAware.CalculateWaste(rod, prices);
                return $"{waste}ft";
            }
            return "N/A";
        }
    }
}
