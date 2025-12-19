using System;
class DistanceConversion{
	static void Main(){
		Console.WriteLine("Enter Distance in feet:");
		double DistanceInFeet= double.Parse(Console.ReadLine());
		double DistanceInYards= DistanceInFeet / 3;
		double DistanceInMiles= DistanceInYards / 1760;
		Console.WriteLine("Your distance in feet is "+DistanceInFeet+" while in yards is "+DistanceInYards+" and miles is "+DistanceInMiles);
	}
}
