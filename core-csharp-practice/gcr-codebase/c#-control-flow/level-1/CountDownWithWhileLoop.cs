using System;
class CountDownWithWhileLoop{
	static void Main(){
		Console.WriteLine("Enter the Count-Down Counter:");
		int Counter =int.Parse(Console.ReadLine());
		while(Counter>0) Console.WriteLine(Counter--);
	}
}