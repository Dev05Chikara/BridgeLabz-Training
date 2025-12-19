using System;
class SwapTwoNumbers{
	static void Main(){
		Console.WriteLine("Enter First Number:");
		double Number1= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		double Number2= double.Parse(Console.ReadLine());
		
		double Temp= Number1;
		Number1= Number2;
		Number2= Temp;
		
		Console.WriteLine("The swapped numbers are "+Number1+" and "+Number2);
	}
}
