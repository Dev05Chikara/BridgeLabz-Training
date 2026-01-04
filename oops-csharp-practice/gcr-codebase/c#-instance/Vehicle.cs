using System;
class Vehicle{
	private string ownerName;
	private string vehicleType;
	public static int registrationFee= 1500;
	
	public Vehicle(string ownerName, string vehicleType){
		this.ownerName= ownerName;
		this.vehicleType= vehicleType;
	}
	
	public void DisplayVehicleDetails(){
		Console.WriteLine("\nVehicle Details:");
		Console.WriteLine("- Owner: "+ownerName);
		Console.WriteLine("- Vehicle Type: "+vehicleType);
		Console.WriteLine("- Registration Fee: "+registrationFee);
	}
	
	public static void UpdateRegistrationFee(int newFee){
		registrationFee= newFee;
	}
}
class Program{
	static void Main(){
		Vehicle v1= new Vehicle("Dev Chikara", "Car");
		v1.DisplayVehicleDetails();
		
		Vehicle.UpdateRegistrationFee(2000);
		
		Vehicle v2= new Vehicle("Krishna", "Bike");
		v2.DisplayVehicleDetails();
	}
}
