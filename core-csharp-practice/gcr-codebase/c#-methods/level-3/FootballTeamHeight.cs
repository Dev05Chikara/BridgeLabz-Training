using System;
class FootballTeamHeight{
    static int FindSum(int[] Heights){
        int Sum = 0;
        for(int i=0;i<Heights.Length;i++){
            Sum += Heights[i];
        }
        return Sum;
    }
    static double FindMean(int[] Heights){
        return (double)FindSum(Heights) / Heights.Length;
    }
    static int FindShortest(int[] Heights){
        int Min = Heights[0];
        for(int i=1;i<Heights.Length;i++){
            if(Heights[i] < Min) Min = Heights[i];
        }
        return Min;
    }
    static int FindTallest(int[] Heights){
        int Max = Heights[0];
        for(int i=1;i<Heights.Length;i++){
            if(Heights[i] > Max) Max = Heights[i];
        }
        return Max;
    }
    static void Main(){
        int[] Heights = new int[11];
        Random R = new Random();
        for(int i=0;i<Heights.Length;i++){
            Heights[i] = R.Next(150,251);
        }
        Console.WriteLine("Player Heights:");
        for(int i=0;i<Heights.Length;i++){
            Console.WriteLine(Heights[i]+" cm");
        }
        Console.WriteLine("Shortest Height: "+FindShortest(Heights)+" cm");
        Console.WriteLine("Tallest Height: "+FindTallest(Heights)+" cm");
        Console.WriteLine("Mean Height: "+FindMean(Heights)+" cm");
    }
}
