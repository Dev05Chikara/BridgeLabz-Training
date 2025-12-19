using System;
class TotalPurchasePrice{
	static void Main(){
		Console.WriteLine("Enter Unit Price of the item:");
		double UnitPrice= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Quantity:");
		double Quantity= double.Parse(Console.ReadLine());
		double TotalPrice= UnitPrice * Quantity;
		Console.WriteLine("The total purchase price is INR "+TotalPrice+" if the quantity "+Quantity+" and unit price is INR "+UnitPrice);
	}
}
