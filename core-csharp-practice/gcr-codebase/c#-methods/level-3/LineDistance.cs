using System;
class LineDistance{
    static double FindDistance(double X1,double Y1,double X2,double Y2){
        return Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
    }
    static double[] FindLineEquation(double X1,double Y1,double X2,double Y2){
        double M=(Y2-Y1)/(X2-X1);
        double B=Y1-(M*X1);
        double[] Result=new double[2];
        Result[0]=M;
        Result[1]=B;
        return Result;
    }
    static void Main(){
        Console.Write("Enter x1: ");
        double X1=double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double Y1=double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double X2=double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double Y2=double.Parse(Console.ReadLine());
        double Distance=FindDistance(X1,Y1,X2,Y2);
        double[] Line=FindLineEquation(X1,Y1,X2,Y2);
        Console.WriteLine("Distance: "+Distance);
        Console.WriteLine("Slope: "+Line[0]);
        Console.WriteLine("Y-Intercept: "+Line[1]);
        Console.WriteLine("Equation: y = "+Line[0]+"x + "+Line[1]);
    }
}
