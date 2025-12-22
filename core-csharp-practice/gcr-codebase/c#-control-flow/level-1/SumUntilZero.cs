using System;
class SumUntilZero{
	static void Main(){
		double Total= 0.0;
		Console.WriteLine("Enter the Value:");
		double Number =double.Parse(Console.ReadLine());
		while(Number != 0){
			Total+=Number;
			Number =double.Parse(Console.ReadLine());
		}
		Console.WriteLine("Total value is: "+Total);
	}
}