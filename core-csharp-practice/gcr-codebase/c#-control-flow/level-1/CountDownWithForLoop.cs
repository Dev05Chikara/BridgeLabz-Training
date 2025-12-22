using System;
class CountDownWithForLoop{
	static void Main(){
		Console.WriteLine("Enter the Count-Down Counter:");
		int Counter =int.Parse(Console.ReadLine());
		for(int counter = Counter;counter>0;counter--)Console.WriteLine(counter);
	}
}