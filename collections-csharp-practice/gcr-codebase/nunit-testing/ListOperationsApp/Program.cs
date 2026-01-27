using System;
using System.Collections.Generic;

namespace ListOperationsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManager manager = new ListManager();
            List<int> numbers = new List<int>();

            manager.AddElement(numbers, 10);
            manager.AddElement(numbers, 20);
            manager.AddElement(numbers, 30);

            Console.WriteLine("Size after adding: " + manager.GetSize(numbers));

            manager.RemoveElement(numbers, 20);
            Console.WriteLine("Size after removing: " + manager.GetSize(numbers));

            Console.ReadLine();
        }
    }
}
