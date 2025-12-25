using System;
class NaturalSumCompare{
    static int RecursiveSum(int Number){
        if(Number == 0) return 0;
        return Number + RecursiveSum(Number-1);
    }
    static int FormulaSum(int Number){
        return ((Number * (Number + 1)) / 2);
    }
    static void Main(){
        Console.Write("Enter number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        if(Number <= 0) return;
        int Sum1 = RecursiveSum(Number);
        int Sum2 = FormulaSum(Number);
        Console.WriteLine("Recursive Sum: "+Sum1);
        Console.WriteLine("Formula Sum: "+Sum2);
    }
}
