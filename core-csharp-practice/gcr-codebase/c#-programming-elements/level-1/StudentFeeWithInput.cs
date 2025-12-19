using System;
class StudentFeeWithInput{
	static void Main(){
		Console.WriteLine("Enter The Fee:");
		int Fee= int.Parse(Console.ReadLine());
		Console.WriteLine("Enter The Discount Percentage:");
		int DiscountPercent= int.Parse(Console.ReadLine());
		int Discount= (Fee*DiscountPercent)/100;
		int DiscountedFee= Fee - Discount;
		Console.WriteLine("The discount amount is INR "+Discount+" and final discounted fee is INR "+DiscountedFee);
	}
}