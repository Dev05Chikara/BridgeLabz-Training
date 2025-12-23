using System;
class PowerOfNumber{
	static void Main(){
		Console.WriteLine("Enter number:");
		int Number = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter power:");
		int Power = int.Parse(Console.ReadLine());
		int Result = 1;
		for(int i = 1; i <= Power; i++) Result = Result * Number;
		Console.WriteLine("Result: " + Result);
	}
}
