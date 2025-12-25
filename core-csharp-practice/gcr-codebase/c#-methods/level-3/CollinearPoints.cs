using System;
class CollinearPoints{
    static bool CheckBySlope(double X1,double Y1,double X2,double Y2,double X3,double Y3){
        double SlopeAB=(Y2-Y1)/(X2-X1);
        double SlopeBC=(Y3-Y2)/(X3-X2);
        double SlopeAC=(Y3-Y1)/(X3-X1);
        return SlopeAB==SlopeBC && SlopeBC==SlopeAC;
    }
    static bool CheckByArea(double X1,double Y1,double X2,double Y2,double X3,double Y3){
        double Area=0.5*(X1*(Y2-Y3)+X2*(Y3-Y1)+X3*(Y1-Y2));
        return Area==0;
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
        Console.Write("Enter x3: ");
        double X3=double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double Y3=double.Parse(Console.ReadLine());
        Console.WriteLine("Collinear By Slope: "+CheckBySlope(X1,Y1,X2,Y2,X3,Y3));
        Console.WriteLine("Collinear By Area: "+CheckByArea(X1,Y1,X2,Y2,X3,Y3));
    }
}
