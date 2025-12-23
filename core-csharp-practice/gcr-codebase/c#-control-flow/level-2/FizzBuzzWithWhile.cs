using System;
class FizzBuzzWithWhile{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int Number = int.Parse(Console.ReadLine());
		if(Number <= 0) Console.WriteLine("Enter a positive integer.");
		else{
			int Counter = 1;
			while(Counter <= Number){
				if(Counter % 3 == 0 && Counter % 5 == 0)
					Console.WriteLine("FizzBuzz");
				else if(Counter % 3 == 0)
					Console.WriteLine("Fizz");
				else if(Counter % 5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(Counter);
				Counter++;
			}
		}
	}
}
