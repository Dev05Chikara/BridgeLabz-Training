using System;
class CarRental{
	private string customerName;
	private string carModel;
	private int rentalDays;
	private int costPerDay= 1500;
	
	public CarRental(string customerName, string carModel, int rentalDays){
		this.customerName= customerName;
		this.carModel= carModel;
		this.rentalDays= rentalDays;
	}
	
	public void DisplayBill(){
		int totalCost= rentalDays * costPerDay;
		Console.WriteLine("\nCar Rental Details:");
		Console.WriteLine("- Customer Name: "+customerName);
		Console.WriteLine("- Car Model: "+carModel);
		Console.WriteLine("- Rental Days: "+rentalDays);
		Console.WriteLine("- Total Cost: "+totalCost);
	}
}
class Program{
	static void Main(){
		CarRental rental1= new CarRental("Dev Chikara", "Hyundai Exter", 4);
		
		rental1.DisplayBill();
	}
}
