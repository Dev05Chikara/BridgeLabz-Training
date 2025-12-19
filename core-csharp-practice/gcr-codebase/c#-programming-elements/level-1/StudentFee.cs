using System;
class StudentFee{
	static void Main(){
		int Fee= 125000;
		int DiscountPercent= 10;
		int Discount= (Fee*DiscountPercent)/100;
		int DiscountedFee= Fee - Discount;
		Console.WriteLine("The discount amount is INR "+Discount+" and final discounted fee is INR "+DiscountedFee);
	}
}