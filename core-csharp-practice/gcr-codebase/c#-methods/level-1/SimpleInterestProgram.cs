using System;
class SimpleInterestProgram{
    static double CalculateSimpleInterest(double Principal,double Rate,double Time){
        return (Principal*Rate*Time)/100;
    }
    static void Main(){
        Console.Write("Enter Principal: ");
        double Principal = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate: ");
        double Rate = double.Parse(Console.ReadLine());
        Console.Write("Enter Time: ");
        double Time = double.Parse(Console.ReadLine());
        double SimpleInterest = CalculateSimpleInterest(Principal,Rate,Time);
        Console.WriteLine("The Simple Interest is "+SimpleInterest+" for Principal "+Principal+", Rate of Interest "+Rate+" and Time "+Time);
    }
}
