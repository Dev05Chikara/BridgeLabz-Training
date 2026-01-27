using System;

namespace PerformanceTestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformanceUtils utils = new PerformanceUtils();
            Console.WriteLine(utils.LongRunningTask());

            Console.ReadLine();
        }
    }
}
