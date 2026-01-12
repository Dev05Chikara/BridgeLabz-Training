using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.metal_factory_pipe_cutting
{
    internal class MetalFactoryMain
    {
        public static void Main(string[] args)
        {
            Rod rod = new Rod(8);
            PriceChart price = new PriceChart();
            price.AddPrice(1, 1);
            price.AddPrice(2, 5);
            price.AddPrice(3, 8);
            price.AddPrice(4, 9);
            price.AddPrice(5, 10);
            price.AddPrice(6, 15);
            price.AddPrice(7, 5);
            price.AddPrice(8, 20);

            IStarategy optimise = new OptimiseImpl();

            FactoryShow.Show(optimise, price, rod);
            Console.WriteLine();

            IStarategy nonOptimise = new NonOptimiseImpl();

            FactoryShow.Show(nonOptimise, price, rod);
            Console.WriteLine();

            // Custom Price 
            price.AddPrice(7, 30);

            FactoryShow.Show(optimise, price, rod);

        }
    }
}
