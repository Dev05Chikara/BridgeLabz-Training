using System;
class HarshadFrequency{
    static int[] StoreDigits(int Number){
        int Count = Number.ToString().Length;
        int[] Digits = new int[Count];
        for(int i=Count-1;i>=0;i--){
            Digits[i] = Number % 10;
            Number /= 10;
        }
        return Digits;
    }
    static int SumOfDigits(int[] Digits){
        int Sum = 0;
        for(int i=0;i<Digits.Length;i++) Sum += Digits[i];
        return Sum;
    }
    static int SumOfSquares(int[] Digits){
        int Sum = 0;
        for(int i=0;i<Digits.Length;i++){
            Sum += (int)Math.Pow(Digits[i],2);
        }
        return Sum;
    }
    static bool IsHarshad(int Number,int[] Digits){
        return Number % SumOfDigits(Digits) == 0;
    }
    static int[,] DigitFrequency(int[] Digits){
        int[,] Freq = new int[10,2];
        for(int i=0;i<10;i++) Freq[i,0] = i;
        for(int i=0;i<Digits.Length;i++){
            Freq[Digits[i],1]++;
        }
        return Freq;
    }
    static void Main(){
        Console.Write("Enter Number: ");
        int Number = int.Parse(Console.ReadLine());
        int[] Digits = StoreDigits(Number);
        Console.WriteLine("Sum: "+SumOfDigits(Digits));
        Console.WriteLine("Sum of Squares: "+SumOfSquares(Digits));
        Console.WriteLine("Harshad: "+IsHarshad(Number,Digits));
        int[,] F = DigitFrequency(Digits);
        for(int i=0;i<10;i++){
            Console.WriteLine(F[i,0]+" -> "+F[i,1]);
        }
    }
}
