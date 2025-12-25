using System;
class WindChill{
    static double CalculateWindChill(double Temperature,double WindSpeed){
        return (35.74 + 0.6215 * Temperature + (0.4275 * Temperature - 35.75) * Math.Pow(WindSpeed,0.16));
    }
    static void Main(){
        Console.Write("Enter temperature: ");
        double Temperature = double.Parse(Console.ReadLine());
        Console.Write("Enter wind speed: ");
        double WindSpeed = double.Parse(Console.ReadLine());
        double WindChillValue = CalculateWindChill(Temperature,WindSpeed);
        Console.WriteLine("Wind Chill Temperature: "+WindChillValue);
    }
}
