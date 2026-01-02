using System;
class BusRoute{
	public void BusStops(string name){
		string[] stops= {
			"Goverdhan", "Ading", "Khamni", "Satoha", "SJB Schl", "Goverdhan Chauraha", "Masani Road", "Chhatikara", "Jait", "GLA University"
		};
		int total=0;
		for(int i=1; i<stops.Length-1; i++){
			Console.Write("Our next stop is: "+stops[i]+". Do you wanna stop here? (y/n): ");
			char answer= Convert.ToChar(Console.ReadLine());
			total=i;
			if(answer=='y' || answer=='Y'){
				Console.WriteLine("\nYour total distance is: "+total+" km.");
				Console.WriteLine("Thanks for using our services. Hope you liked it, "+name);
				return;
			}
		}
		Console.WriteLine("\n"+stops[stops.Length-1]+" is our last stop.");
		Console.WriteLine("Your total distance is: "+(total+1)+" km.");
		Console.WriteLine("Thanks for using our services. Hope you liked it, "+name);
	}
}

class Program{
	static void Main(){
		Console.Write("Please enter your name: ");
		string name= Console.ReadLine();
		Console.WriteLine("\nLet's Start the Journey! "+name);
		BusRoute route= new BusRoute();
		route.BusStops(name);
	}
}