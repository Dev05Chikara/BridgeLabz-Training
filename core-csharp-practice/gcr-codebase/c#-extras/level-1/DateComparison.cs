using System;
class DateComparison{
	static void CompareDates(DateTime d1, DateTime d2){
		int result = DateTime.Compare(d1, d2);
		if(result < 0) Console.WriteLine("First date is BEFORE second date");
		else if(result > 0) Console.WriteLine("First date is AFTER second date");
		else Console.WriteLine("Both dates are SAME");
	}
	static void Main(){
		Console.Write("Enter First Date (yyyy-mm-dd): ");
		DateTime d1 = DateTime.Parse(Console.ReadLine());
		Console.Write("Enter Second Date (yyyy-mm-dd): ");
		DateTime d2 = DateTime.Parse(Console.ReadLine());
		CompareDates(d1, d2);
	}
}
