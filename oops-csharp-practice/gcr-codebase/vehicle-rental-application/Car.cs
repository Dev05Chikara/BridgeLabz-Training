using System;
class Car : Vehicle, IRentable{
	
	public Car(string vehicleNumber, string brand, double baseRate)
		: base(vehicleNumber, brand, baseRate){
	}
	
	public double CalculateRent(int days){
		return (baseRate * days) + 500;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("\nCar Details:");
		Console.WriteLine("Vehicle No: "+vehicleNumber);
		Console.WriteLine("Brand: "+brand);
		Console.WriteLine("Base Rate Per Day: "+baseRate);
	}
}
