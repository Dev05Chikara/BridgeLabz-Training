using System;

namespace ParameterizedTestsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberUtils utils = new NumberUtils();

            Console.WriteLine(utils.IsEven(2)); 
            Console.WriteLine(utils.IsEven(7)); 

            Console.ReadLine();
        }
    }
}
