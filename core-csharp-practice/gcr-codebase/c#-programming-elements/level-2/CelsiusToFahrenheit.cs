using System;
class CelsiusToFahrenheit{
	static void Main(){
		Console.WriteLine("Enter Temperature in Celsius:");
		double Celsius= double.Parse(Console.ReadLine());
		double FahrenheitResult= (Celsius * 9 / 5) + 32;
		Console.WriteLine("The "+Celsius+" Celsius is "+FahrenheitResult+" Fahrenheit");
	}
}
