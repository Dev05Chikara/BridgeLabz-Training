using System;
class Quadratic{
    static double[] FindRoots(double A,double B,double C){
        double Delta = (B * B) - (4 * A * C);
        if(Delta < 0) return new double[0];
        if(Delta == 0){
            return new double[]{-B/(2*A)};
        }
        double Root1 = (-B + Math.Sqrt(Delta))/(2*A);
        double Root2 = (-B - Math.Sqrt(Delta))/(2*A);
        return new double[]{Root1,Root2};
    }
    static void Main(){
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double[] Roots = FindRoots(A,B,C);
        for(int i=0;i<Roots.Length;i++){
            Console.WriteLine(Roots[i]);
        }
    }
}
