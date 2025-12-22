using System;
class OddEvenNumbers{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int number = int.Parse(Console.ReadLine());
		if(number <= 0) Console.WriteLine("Invalid input. Enter a natural number.");
		for(int i=1; i <= number; i++){
			if(i%2 == 0)
				Console.WriteLine(i+ " is Even");
			else
				Console.WriteLine(i+ " is Odd");
		}
	}
}
