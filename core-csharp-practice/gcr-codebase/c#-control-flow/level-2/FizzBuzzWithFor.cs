using System;
class FizzBuzzWithFor{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int Number = int.Parse(Console.ReadLine());
		if(Number <= 0) Console.WriteLine("Invalid input. Enter a positive integer.");
		else{
			for(int Counter=1; Counter<=Number; Counter++){
				if(Counter%3 == 0 && Counter%5 == 0)
					Console.WriteLine("FizzBuzz");
				else if(Counter%3 == 0)
					Console.WriteLine("Fizz");
				else if(Counter%5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(Counter);
			}
		}
	}
}
