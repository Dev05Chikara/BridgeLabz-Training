using System;
class FactorsPerfectAbundantDeficientStrong{
    static int[] FindFactors(int N){
        int Count = 0;
        for(int i=1;i<=N;i++) if(N%i==0) Count++;
        int[] F = new int[Count];
        int k = 0;
        for(int i=1;i<=N;i++) if(N%i==0) F[k++] = i;
        return F;
    }
    static bool IsPerfect(int N){
        int Sum = 0;
        for(int i=1;i<N;i++) if(N%i==0) Sum += i;
        return Sum == N;
    }
    static bool IsAbundant(int N){
        int Sum = 0;
        for(int i=1;i<N;i++) if(N%i==0) Sum += i;
        return Sum > N;
    }
    static bool IsDeficient(int N){
        int Sum = 0;
        for(int i=1;i<N;i++) if(N%i==0) Sum += i;
        return Sum < N;
    }
    static int Fact(int N){
        int F = 1;
        for(int i=1;i<=N;i++) F *= i;
        return F;
    }
    static bool IsStrong(int N){
        int T = N, Sum = 0;
        while(T > 0){
            Sum += Fact(T%10);
            T /= 10;
        }
        return Sum == N;
    }
    static void Main(){
        Console.Write("Enter Number: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Perfect: "+IsPerfect(N));
        Console.WriteLine("Abundant: "+IsAbundant(N));
        Console.WriteLine("Deficient: "+IsDeficient(N));
        Console.WriteLine("Strong: "+IsStrong(N));
    }
}
