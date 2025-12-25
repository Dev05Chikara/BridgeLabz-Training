using System;
class QuotientRemainder{
    static int[] FindRemainderAndQuotient(int Number,int Divisor){
        int Quotient = Number / Divisor;
        int Remainder = Number % Divisor;
        return new int[]{Quotient,Remainder};
    }
    static void Main(){
        Console.Write("Enter number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter divisor: ");
        int Divisor = Convert.ToInt32(Console.ReadLine());
        int[] Result = FindRemainderAndQuotient(Number,Divisor);
        Console.WriteLine("Quotient: "+Result[0]);
        Console.WriteLine("Remainder: "+Result[1]);
    }
}
