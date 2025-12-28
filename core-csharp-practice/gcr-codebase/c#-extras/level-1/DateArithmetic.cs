using System;
class DateArithmetic{
	static void CalculateDate(DateTime date){
		DateTime result = date.AddDays(7);
		result = result.AddMonths(1);
		result = result.AddYears(2);
		result = result.AddDays(-21);
		Console.WriteLine("Final Date: " + result.ToShortDateString());
	}
	static void Main(){
		Console.Write("Enter Date (yyyy-mm-dd): ");
		DateTime date = DateTime.Parse(Console.ReadLine());
		CalculateDate(date);
	}
}
