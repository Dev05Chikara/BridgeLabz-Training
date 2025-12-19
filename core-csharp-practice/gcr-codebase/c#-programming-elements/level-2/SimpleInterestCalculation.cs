using System;
class SimpleInterestCalculation{
	static void Main(){
		Console.WriteLine("Enter Principal:");
		double Principal= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Rate of Interest:");
		double Rate= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Time (in years):");
		double Time= double.Parse(Console.ReadLine());
		
		double SimpleInterest= (Principal * Rate * Time) / 100;
		
		Console.WriteLine("The Simple Interest is "+SimpleInterest+" for Principal "+Principal+", Rate of Interest "+Rate+" and Time "+Time);
	}
}
