using System;
using System.Collections.Generic;

interface IGPS{
	string GetCurrentLocation();
	void UpdateLocation(string location);
}

abstract class VehicleFare{
	private int VehicleFareId;
	protected double ratePerKm;

	public VehicleFare(int id, double rate){
		this.VehicleFareId= id;
		this.ratePerKm= rate;
	}

	public abstract double CalculateFare(double distance);

	public void GetVehicleFareDetails(){
		Console.WriteLine("\nVehicleFare ID: "+VehicleFareId);
	}
}

class Car : VehicleFare{
	public Car(int id, double rate)
		: base(id, rate){}

	public override double CalculateFare(double distance){
		return ratePerKm * distance;
	}
}

class Program{
	static void Main(){
		List<VehicleFare> rides= new List<VehicleFare>();
		rides.Add(new Car(101, 12));

		foreach(VehicleFare v in rides){
			v.GetVehicleFareDetails();
			Console.WriteLine("Fare: "+v.CalculateFare(10));
		}
	}
}
