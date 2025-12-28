using System;
class TemperatureConverter{
	static double CelsiusToFahrenheit(double c){
		return (c * 9 / 5) + 32;
	}
	static double FahrenheitToCelsius(double f){
		return (f - 32) * 5 / 9;
	}
	static void Main(){
		Console.Write("Enter temperature: ");
		double temp = double.Parse(Console.ReadLine());
		Console.WriteLine("C to F: " + CelsiusToFahrenheit(temp));
		Console.WriteLine("F to C: " + FahrenheitToCelsius(temp));
	}
}
