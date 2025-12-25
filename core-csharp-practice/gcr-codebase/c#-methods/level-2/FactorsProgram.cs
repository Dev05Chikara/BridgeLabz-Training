using System;
class FactorsProgram{
    static int[] FindFactors(int Number){
        int Count = 0;
        for(int i=1;i<=Number;i++) if(Number % i == 0) Count++;
        int[] Factors = new int[Count];
        int Index = 0;
        for(int i=1;i<=Number;i++){
            if(Number % i == 0){
                Factors[Index] = i;
                Index++;
            }
        }
        return Factors;
    }
    static int FindSum(int[] Factors){
        int Sum = 0;
        for(int i=0;i<Factors.Length;i++) Sum += Factors[i];
        return Sum;
    }
    static int FindProduct(int[] Factors){
        int Product = 1;
        for(int i=0;i<Factors.Length;i++) Product *= Factors[i];
        return Product;
    }
    static double FindSumOfSquares(int[] Factors){
        double Sum = 0;
        for(int i=0;i<Factors.Length;i++) Sum += Math.Pow(Factors[i],2);
        return Sum;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        int[] Factors = FindFactors(Number);
		Console.Write("Factors are: ");
        for(int i=0;i<Factors.Length;i++) Console.Write(Factors[i]+" ");
        Console.WriteLine("\nSum: "+FindSum(Factors));
        Console.WriteLine("Product: "+FindProduct(Factors));
        Console.WriteLine("Sum of Squares: "+FindSumOfSquares(Factors));
    }
}
