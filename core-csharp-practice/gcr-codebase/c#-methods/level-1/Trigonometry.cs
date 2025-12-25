using System;
class Trigonometry{
    static double[] CalculateTrigonometricFunctions(double Angle){
        double Radian = Angle * Math.PI / 180;
        double Sin = Math.Sin(Radian);
        double Cos = Math.Cos(Radian);
        double Tan = Math.Tan(Radian);
        return new double[]{Sin,Cos,Tan};
    }
    static void Main(){
        Console.Write("Enter angle in degrees: ");
        double Angle = double.Parse(Console.ReadLine());
        double[] Result = CalculateTrigonometricFunctions(Angle);
        Console.WriteLine("Sin: "+Result[0]);
        Console.WriteLine("Cos: "+Result[1]);
        Console.WriteLine("Tan: "+Result[2]);
    }
}
