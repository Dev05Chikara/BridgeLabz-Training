using System;
class SumOfNaturalNumbers{
    static int CalculateSum(int Number){
        int Sum = 0;
        for(int i=1;i<=Number;i++) Sum += i;
        return Sum;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum is: "+CalculateSum(Number));
    }
}
