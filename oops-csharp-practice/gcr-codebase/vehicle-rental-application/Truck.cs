using System;
class Truck : Vehicle, IRentable{
	
	public Truck(string vehicleNumber, string brand, double baseRate)
		: base(vehicleNumber, brand, baseRate){
	}
	
	public double CalculateRent(int days){
		return (baseRate * days) + 1000;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("\nTruck Details:");
		Console.WriteLine("Vehicle No: "+vehicleNumber);
		Console.WriteLine("Brand: "+brand);
		Console.WriteLine("Base Rate Per Day: "+baseRate);
	}
}
