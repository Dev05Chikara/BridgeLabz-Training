using System;
class AbundantNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number =int.Parse(Console.ReadLine());
        int Sum =0;
        for(int i=1; i<Number; i++){
            if(Number % i == 0) Sum += i;
        }
        if(Sum > Number) Console.WriteLine("Abundant Number");
        else Console.WriteLine("Not an Abundant Number");
    }
}
