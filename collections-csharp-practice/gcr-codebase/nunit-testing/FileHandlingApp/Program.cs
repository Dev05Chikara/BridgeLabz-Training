using System;

namespace FileHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileProcessor processor = new FileProcessor();
            string file = "sample.txt";

            processor.WriteToFile(file, "Hello NUnit");
            Console.WriteLine(processor.ReadFromFile(file));

            Console.ReadLine();
        }
    }
}
