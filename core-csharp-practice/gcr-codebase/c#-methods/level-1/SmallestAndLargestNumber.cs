using System;
class SmallestAndLargestNumber{
    static int[] FindSmallestAndLargest(int Number1,int Number2,int Number3){
        int Smallest = Number1;
        int Largest = Number1;
        if(Number2 < Smallest) Smallest = Number2;
        if(Number3 < Smallest) Smallest = Number3;
        if(Number2 > Largest) Largest = Number2;
        if(Number3 > Largest) Largest = Number3;
        return new int[]{Smallest,Largest};
    }
    static void Main(){
        Console.Write("Enter first number: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int Number3 = Convert.ToInt32(Console.ReadLine());
        int[] Result = FindSmallestAndLargest(Number1,Number2,Number3);
        Console.WriteLine("Smallest: "+Result[0]);
        Console.WriteLine("Largest: "+Result[1]);
    }
}
