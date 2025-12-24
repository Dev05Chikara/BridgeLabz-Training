using System;
class FactorsOfNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= int.Parse(Console.ReadLine());
        int MaxFactor= 10;
        int[] Factors= new int[MaxFactor];
        int Index= 0;
        for(int i=1; i<=Number; i++){
            if(Number%i == 0)
            {
                if(Index == MaxFactor)
                {
                    MaxFactor *= 2;
                    int[] Temp= new int[MaxFactor];
                    for (int j=0; j<Factors.Length; j++) Temp[j]= Factors[j];
                    Factors= Temp;
                }
                Factors[Index]= i;
                Index++;
            }
        }
        Console.Write("Factors are: ");
        for(int i=0; i<Index; i++) Console.Write(Factors[i] + " ");
    }
}
