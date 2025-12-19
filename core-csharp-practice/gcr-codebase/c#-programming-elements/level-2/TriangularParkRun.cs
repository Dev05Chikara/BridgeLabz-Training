using System;
class TriangularParkRun{
	static void Main(){
		Console.WriteLine("Enter Side 1 of the Triangle (in meters):");
		double Side1= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Side 2 of the Triangle (in meters):");
		double Side2= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Side 3 of the Triangle (in meters):");
		double Side3= double.Parse(Console.ReadLine());
		
		double Perimeter= Side1 + Side2 + Side3; // Total distance of one round in meters
		double DistanceToRun= 5000; // 5 km in meters
		double Rounds= DistanceToRun / Perimeter;
		
		Console.WriteLine("The total number of rounds the athlete will run is "+Rounds+" to complete 5 km");
	}
}
