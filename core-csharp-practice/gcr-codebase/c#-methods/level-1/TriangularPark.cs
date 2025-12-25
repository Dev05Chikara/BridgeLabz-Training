using System;
class TriangularPark{
    static double CalculateRounds(double Side1,double Side2,double Side3){
        double Perimeter = Side1 + Side2 + Side3;
        return (5000 / Perimeter);
    }
    static void Main(){
        Console.Write("Enter Side 1: ");
        double Side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Side 2: ");
        double Side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter Side 3: ");
        double Side3 = double.Parse(Console.ReadLine());
        double Rounds = CalculateRounds(Side1,Side2,Side3);
        Console.WriteLine("Rounds required: "+Rounds);
    }
}
