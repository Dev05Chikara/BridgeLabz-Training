using System;
class FactorsOfNumber{
	static void Main(){
		Console.WriteLine("Enter a number:");
		int Number = int.Parse(Console.ReadLine());
		Console.WriteLine("Factors are:");
		for(int i = 1; i < Number; i++){
			if(Number % i == 0) Console.WriteLine(i);
		}
	}
}
