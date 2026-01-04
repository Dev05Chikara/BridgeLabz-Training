using System;
class Vehicle{
	public static int RegistrationFee= 2000;
	
	public readonly string RegistrationNumber;
	private string OwnerName;
	private string VehicleType;
	
	public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber){
		this.OwnerName= OwnerName;
		this.VehicleType= VehicleType;
		this.RegistrationNumber= RegistrationNumber;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nVehicle Details:");
		Console.WriteLine("Owner: "+OwnerName);
		Console.WriteLine("Type: "+VehicleType);
		Console.WriteLine("Reg No: "+RegistrationNumber);
		Console.WriteLine("Fee: "+RegistrationFee);
	}
	
	public static void UpdateRegistrationFee(int fee){
		RegistrationFee= fee;
	}
}
class Program{
	static void Main(){
		object v= new Vehicle("Dev", "Car", "UP85AB1234");
		
		if(v is Vehicle){
			((Vehicle)v).DisplayDetails();
		}
	}
}
