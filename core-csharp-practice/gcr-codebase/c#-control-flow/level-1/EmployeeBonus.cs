using System;
class EmployeeBonus{
	static void Main(){
		Console.WriteLine("Enter the Salary:");
		double Salary = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Years of Service:");
		int Years= int.Parse(Console.ReadLine());
		double Bonus = 0.0;
		if(Years > 5) Bonus = Salary * 0.05;
		Console.WriteLine("Bonus Amount is: " + Bonus);
	}
}
