using System;
class HarshadNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number =int.Parse(Console.ReadLine());
        int Temp =Number;
        int Sum =0;
        while(Temp != 0)
        {
            Sum += Temp%10;
            Temp /= 10;
        }
        if(Number%Sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
