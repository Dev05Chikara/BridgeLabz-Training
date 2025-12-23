using System;
class MultiplesBelowHundred{
	static void Main(){
		Console.WriteLine("Enter a number:");
		int Number = int.Parse(Console.ReadLine());
		for(int i = 100; i >= 1; i--){
			if(i % Number == 0) Console.WriteLine(i);
		}
	}
}
