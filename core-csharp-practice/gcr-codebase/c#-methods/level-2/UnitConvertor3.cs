using System;
class UnitConvertor3{
    public static void ConvertFahrenheitToOthers(){
        Console.Write("Enter the temperature in Fahrenheit: ");
        double Fahrenheit = double.Parse(Console.ReadLine());
        if(Fahrenheit < -459.67) Console.WriteLine("Enter valid temperature.");
        else{
            Console.WriteLine((Fahrenheit - 32) * 5 / 9 + " Celsius");
        }
    }
    public static void ConvertCelsiusToOthers(){
        Console.Write("Enter the temperature in Celsius: ");
        double Celsius = double.Parse(Console.ReadLine());
        if(Celsius < -273.15) Console.WriteLine("Enter valid temperature.");
        else{
            Console.WriteLine((Celsius * 9 / 5) + 32 + " Fahrenheit");
        }
    }
    public static void ConvertPoundsToOthers(){
        Console.Write("Enter the weight in Pounds: ");
        double Pounds = double.Parse(Console.ReadLine());
        if(Pounds < 0) Console.WriteLine("Enter valid weight.");
        else{
            Console.WriteLine(Pounds * 0.453592 + " Kilograms");
        }
    }
    public static void ConvertKgToOthers(){
        Console.Write("Enter the weight in Kilograms: ");
        double Kg = double.Parse(Console.ReadLine());
        if(Kg < 0) Console.WriteLine("Enter valid weight.");
        else{
            Console.WriteLine(Kg * 2.20462 + " Pounds");
        }
    }
    public static void ConvertGallonsToOthers(){
        Console.Write("Enter the volume in Gallons: ");
        double Gallons = double.Parse(Console.ReadLine());
        if(Gallons < 0) Console.WriteLine("Enter valid volume.");
        else{
            Console.WriteLine(Gallons * 3.78541 + " Liters");
        }
    }
    public static void ConvertLitersToOthers(){
        Console.Write("Enter the volume in Liters: ");
        double Liters = double.Parse(Console.ReadLine());
        if(Liters < 0) Console.WriteLine("Enter valid volume.");
        else{
            Console.WriteLine(Liters * 0.264172 + " Gallons");
        }
    }
    static void Main(){
        Console.WriteLine("What do you want to convert?");
        Console.Write("Fahrenheit(1), Celsius(2), Pounds(3), Kg(4), Gallons(5), Liters(6): ");
        int Case = int.Parse(Console.ReadLine());
        switch(Case){
            case 1:
                ConvertFahrenheitToOthers();
                break;
            case 2:
                ConvertCelsiusToOthers();
                break;
            case 3:
                ConvertPoundsToOthers();
                break;
            case 4:
                ConvertKgToOthers();
                break;
            case 5:
                ConvertGallonsToOthers();
                break;
            case 6:
                ConvertLitersToOthers();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
