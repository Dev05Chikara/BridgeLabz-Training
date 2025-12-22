using System;
class SumOfNaturalNumbersWithWhileLoop{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int n=int.Parse(Console.ReadLine());
		if(n <= 0) Console.WriteLine("Invalid input. Enter a natural number.");
		int SumWhile= 0;
		int i= 1;
		while(i <= n){
			SumWhile += i;
			i++;
		}
		int SumFormula= (n*(n + 1))/2;
		Console.WriteLine("Sum using while loop: " + SumWhile);
		Console.WriteLine("Sum using formula: " + SumFormula);
		if(SumWhile == SumFormula) Console.WriteLine("Same Results.");
		else Console.WriteLine("Results mismatched.");
	}
}
