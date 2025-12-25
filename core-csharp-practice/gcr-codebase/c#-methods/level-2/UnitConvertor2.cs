using System;
class UnitConvertor2{
    public static void ConvertYardsToOthers(){
        Console.Write("Enter the length in Yards: ");
        double Yards = double.Parse(Console.ReadLine());
        if(Yards < 0) Console.WriteLine("Enter valid length.");
        else{
            Console.WriteLine(Yards * 3 + " Feet");
            Console.WriteLine(Yards * 0.9144 + " Meters");
            Console.WriteLine(Yards * 36 + " Inches");
        }
    }
    public static void ConvertFeetToOthers(){
        Console.Write("Enter the length in Feet: ");
        double Feet = double.Parse(Console.ReadLine());
        if(Feet < 0) Console.WriteLine("Enter valid length.");
        else{
            Console.WriteLine(Feet * 0.333333 + " Yards");
            Console.WriteLine(Feet * 0.3048 + " Meters");
            Console.WriteLine(Feet * 12 + " Inches");
        }
    }
    public static void ConvertMetersToOthers(){
        Console.Write("Enter the length in Meters: ");
        double Meters = double.Parse(Console.ReadLine());
        if(Meters < 0) Console.WriteLine("Enter valid length.");
        else{
            Console.WriteLine(Meters * 1.09361 + " Yards");
            Console.WriteLine(Meters * 3.28084 + " Feet");
            Console.WriteLine(Meters * 39.3701 + " Inches");
        }
    }
    public static void ConvertInchesToOthers(){
        Console.Write("Enter the length in Inches: ");
        double Inches = double.Parse(Console.ReadLine());
        if(Inches < 0) Console.WriteLine("Enter valid length.");
        else{
            Console.WriteLine(Inches * 0.0277778 + " Yards");
            Console.WriteLine(Inches * 0.0833333 + " Feet");
            Console.WriteLine(Inches * 0.0254 + " Meters");
        }
    }
    static void Main(){
        Console.WriteLine("In Which length you want to enter the length?");
        Console.Write("For: Yards(Enter 1), Feet(Enter 2), Meters(Enter 3), Inches(Enter 4): ");
        int Case = int.Parse(Console.ReadLine());
        switch(Case){
            case 1:
                ConvertYardsToOthers();
                break;
            case 2:
                ConvertFeetToOthers();
                break;
            case 3:
                ConvertMetersToOthers();
                break;
            case 4:
                ConvertInchesToOthers();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
