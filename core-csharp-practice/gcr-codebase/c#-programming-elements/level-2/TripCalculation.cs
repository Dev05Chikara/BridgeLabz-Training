using System;
class TripCalculation{
	static void Main(){
		Console.WriteLine("Enter Name of the Person:");
		string Name= Console.ReadLine();
		
		Console.WriteLine("Enter Starting City:");
		string FromCity= Console.ReadLine();
		
		Console.WriteLine("Enter Via City:");
		string ViaCity= Console.ReadLine();
		
		Console.WriteLine("Enter Destination City:");
		string ToCity= Console.ReadLine();
		
		Console.WriteLine("Enter Distance from Starting City to Via City (in miles):");
		double FromToVia= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Distance from Via City to Destination City (in miles):");
		double ViaToFinalCity= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Time taken from Starting City to Via City (in minutes):");
		int TimeFromToVia= int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Time taken from Via City to Destination City (in minutes):");
		int TimeViaToFinalCity= int.Parse(Console.ReadLine());
		
		double TotalDistance= FromToVia + ViaToFinalCity;
		int TotalTime= TimeFromToVia + TimeViaToFinalCity;
		
		Console.WriteLine("The results of the trip are: "+TotalDistance+" miles, "+TotalTime+" minutes, traveled by "+Name+" from "+FromCity+" to "+ToCity+" via "+ViaCity);
	}
}
