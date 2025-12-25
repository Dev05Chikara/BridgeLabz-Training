using System;
class RandomStats{
    static int[] Generate4DigitRandomArray(int Size){
        int[] Numbers = new int[Size];
        Random R = new Random();
        for(int i=0;i<Size;i++) Numbers[i] = R.Next(1000,9999);
        return Numbers;
    }
    static double[] FindAverageMinMax(int[] Numbers){
        int Min = Numbers[0];
        int Max = Numbers[0];
        int Sum = 0;
        for(int i=0;i<Numbers.Length;i++){
            Sum += Numbers[i];
            Min = Math.Min(Min,Numbers[i]);
            Max = Math.Max(Max,Numbers[i]);
        }
        double Avg = (double)Sum / Numbers.Length;
        return new double[]{Avg,Min,Max};
    }
    static void Main(){
        int[] Numbers = Generate4DigitRandomArray(5);
        double[] Result = FindAverageMinMax(Numbers);
        for(int i=0;i<Numbers.Length;i++) Console.WriteLine(Numbers[i]);
        Console.WriteLine("Average: "+Result[0]);
        Console.WriteLine("Min: "+Result[1]);
        Console.WriteLine("Max: "+Result[2]);
    }
}
