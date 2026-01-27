using System;

namespace ExceptionHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathUtils math = new MathUtils();

            try
            {
                Console.WriteLine("Result: " + math.Divide(10, 2));
                Console.WriteLine("Result: " + math.Divide(10, 0));
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
