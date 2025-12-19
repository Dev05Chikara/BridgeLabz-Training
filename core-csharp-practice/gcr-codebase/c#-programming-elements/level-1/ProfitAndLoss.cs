using System;
class ProfitAndLoss{
	static void Main(){
		int CostPrice= 129;
		int SellingPrice= 191;
		int Profit = SellingPrice - CostPrice;
		int ProfitPercentage = (Profit*100)/ CostPrice;
		Console.WriteLine("The Cost Price is INR " + CostPrice + " and Selling Price is INR " + SellingPrice);
		Console.WriteLine("The Profit is INR "+Profit+" and the Profit Percentage is "+ProfitPercentage);
	}
}