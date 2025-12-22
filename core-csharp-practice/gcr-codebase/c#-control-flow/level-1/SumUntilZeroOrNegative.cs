using System;
class SumUntilZeroOrNegative{
	static void Main(){
		double Total= 0.0;
		Console.WriteLine("Enter the Value:");
		while(true){
			double Number =double.Parse(Console.ReadLine());
			if (Number <=0)break;
			Total+=Number;
		}
		Console.WriteLine("Total value is: "+Total);
	}
}