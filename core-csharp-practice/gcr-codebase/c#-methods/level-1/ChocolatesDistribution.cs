using System;
class ChocolatesDistribution{
    static int[] FindRemainderAndQuotient(int Chocolates,int Children){
        int EachGets = Chocolates / Children;
        int Remaining = Chocolates % Children;
        return new int[]{EachGets,Remaining};
    }
    static void Main(){
        Console.Write("Enter number of chocolates: ");
        int Chocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int Children = Convert.ToInt32(Console.ReadLine());
        int[] Result = FindRemainderAndQuotient(Chocolates,Children);
        Console.WriteLine("Each child gets: "+Result[0]);
        Console.WriteLine("Remaining chocolates: "+Result[1]);
    }
}
