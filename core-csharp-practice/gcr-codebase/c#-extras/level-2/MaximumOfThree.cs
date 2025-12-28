using System;
class MaximumOfThree{
	static int FindMax(int a, int b, int c){
		int max = a;
		if(b > max) max = b;
		if(c > max) max = c;
		return max;
	}
	static void Main(){
		Console.WriteLine("Enter three numbers:");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		Console.WriteLine("Maximum: " + FindMax(a, b, c));
	}
}
