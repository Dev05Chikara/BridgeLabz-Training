using System;
using System.Collections.Generic;

interface IInsurable{
	double CalculateInsurance();
	string GetInsuranceDetails();
}

abstract class VehicleRent{
	private string VehicleRentNumber;
	protected double rentalRate;

	public VehicleRent(string number, double rate){
		this.VehicleRentNumber= number;
		this.rentalRate= rate;
	}

	public abstract double CalculateRentalCost(int days);

	public void DisplayVehicleRent(){
		Console.WriteLine("\nVehicleRent No: "+VehicleRentNumber);
	}
}

class Car : VehicleRent, IInsurable{
	public Car(string number, double rate)
		: base(number, rate){}

	public override double CalculateRentalCost(int days){
		return rentalRate * days;
	}

	public double CalculateInsurance(){
		return 500;
	}

	public string GetInsuranceDetails(){
		return "Car Insurance";
	}
}

class Program{
	static void Main(){
		List<VehicleRent> VehicleRents= new List<VehicleRent>();
		VehicleRents.Add(new Car("UP85BY1234", 1500));
		VehicleRents.Add(new Car("UP85CU4253", 1700));

		foreach(VehicleRent v in VehicleRents){
			v.DisplayVehicleRent();
			Console.WriteLine("Rent: "+v.CalculateRentalCost(3));
		}
	}
}
