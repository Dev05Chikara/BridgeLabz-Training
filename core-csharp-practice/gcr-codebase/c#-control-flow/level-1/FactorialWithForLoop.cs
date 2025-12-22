using System;
class FactorialWithForLoop{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int n=int.Parse(Console.ReadLine());
		if(n < 0) Console.WriteLine("Invalid input. Enter a natural number.");
		long Factorial= 1;
		for(int i=1; i<=n; i++){
			Factorial *= i;
		}
		Console.WriteLine("Factorial of "+n+" is: "+Factorial);
	}
}
