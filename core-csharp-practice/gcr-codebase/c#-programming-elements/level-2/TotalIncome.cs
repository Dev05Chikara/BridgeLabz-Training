using System;
class TotalIncome{
	static void Main(){
		Console.WriteLine("Enter Salary:");
		double Salary= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Bonus:");
		double Bonus= double.Parse(Console.ReadLine());
		double TotalIncome= Salary + Bonus;
		Console.WriteLine("The salary is INR "+Salary+" and bonus is INR "+Bonus+". Hence Total Income is INR "+TotalIncome);
	}
}
