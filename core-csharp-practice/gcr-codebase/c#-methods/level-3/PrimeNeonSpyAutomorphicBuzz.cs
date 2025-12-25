using System;
class PrimeNeonSpyAutomorphicBuzz{
    static bool IsPrime(int N){
        if(N <= 1) return false;
        for(int i=2;i<=Math.Sqrt(N);i++){
            if(N % i == 0) return false;
        }
        return true;
    }
    static bool IsNeon(int N){
        int Sq = N*N, Sum = 0;
        while(Sq > 0){
            Sum += Sq % 10;
            Sq /= 10;
        }
        return Sum == N;
    }
    static bool IsSpy(int N){
        int Sum = 0, Prod = 1;
        while(N > 0){
            int D = N % 10;
            Sum += D;
            Prod *= D;
            N /= 10;
        }
        return Sum == Prod;
    }
    static bool IsAutomorphic(int N){
        return (N*N).ToString().EndsWith(N.ToString());
    }
    static bool IsBuzz(int N){
        return N % 7 == 0 || N % 10 == 7;
    }
    static void Main(){
        Console.Write("Enter Number: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime: "+IsPrime(N));
        Console.WriteLine("Neon: "+IsNeon(N));
        Console.WriteLine("Spy: "+IsSpy(N));
        Console.WriteLine("Automorphic: "+IsAutomorphic(N));
        Console.WriteLine("Buzz: "+IsBuzz(N));
    }
}
