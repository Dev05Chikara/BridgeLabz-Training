using System;
abstract class Vehicle{
	protected string vehicleNumber;
	protected string brand;
	protected double baseRate;
	
	public Vehicle(string vehicleNumber, string brand, double baseRate){
		this.vehicleNumber= vehicleNumber;
		this.brand= brand;
		this.baseRate= baseRate;
	}
	
	public abstract void DisplayInfo();
}
