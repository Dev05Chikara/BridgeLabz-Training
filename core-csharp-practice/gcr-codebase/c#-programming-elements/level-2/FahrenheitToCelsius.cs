using System;
class FahrenheitToCelsius{
	static void Main(){
		Console.WriteLine("Enter Temperature in Fahrenheit:");
		double Fahrenheit= double.Parse(Console.ReadLine());
		double CelsiusResult= (Fahrenheit - 32) * 5 / 9;
		Console.WriteLine("The "+Fahrenheit+" Fahrenheit is "+CelsiusResult+" Celsius");
	}
}
