using System;
class DigitCount{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= int.Parse(Console.ReadLine());
        int Count = 0;
        while(Number != 0)
        {
            Number /= 10;
            Count++;
        }
        Console.WriteLine("Number of digits: "+Count);
    }
}
