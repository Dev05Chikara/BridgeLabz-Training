using System;
class FactorialWithWhileLoop{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int n=int.Parse(Console.ReadLine());
		if(n < 0) Console.WriteLine("Invalid input. Enter a positive integer.");
		long Factorial= 1;
		int i= 1;
		while(i <= n){
			Factorial *= i;
			i++;
		}
		Console.WriteLine("Factorial of "+n+" is: "+Factorial);
	}
}
