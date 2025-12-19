using System;
class KilometersToMilesWithInput{
	static void Main(){
		Console.WriteLine("Enter the distance in KiloMeter: ");
		double Km= double.Parse(Console.ReadLine());
		double Miles= Km * 1.6;
		Console.WriteLine("The total miles is "+Miles+" mile for the given "+Km+" km");
	}
}