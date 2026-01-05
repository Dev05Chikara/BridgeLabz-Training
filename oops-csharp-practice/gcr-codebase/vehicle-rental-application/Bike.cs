using System;
class Bike : Vehicle, IRentable{
	
	public Bike(string vehicleNumber, string brand, double baseRate)
		: base(vehicleNumber, brand, baseRate){
	}
	
	public double CalculateRent(int days){
		return baseRate * days;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("\nBike Details:");
		Console.WriteLine("Vehicle No: "+vehicleNumber);
		Console.WriteLine("Brand: "+brand);
		Console.WriteLine("Base Rate Per Day: "+baseRate);
	}
}
