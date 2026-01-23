using System;

class NestedTryDemo
{
    static void Main()
    {
        int[] arr = { 10, 20, 30 };

        Console.Write("Enter index: ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        try
        {
            try
            {
                int result = arr[index] / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
