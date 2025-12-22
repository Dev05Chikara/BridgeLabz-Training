using System;
class SumOfNaturalNumbersWithForLoop{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int n=int.Parse(Console.ReadLine());
		if(n <= 0) Console.WriteLine("Invalid input. Enter a natural number.");
		int SumFor= 0;
		for(int i=1;i<=n;i++) SumFor += i;
		int SumFormula= (n*(n + 1))/2;
		Console.WriteLine("Sum using for loop: " + SumFor);
		Console.WriteLine("Sum using formula: " + SumFormula);
		if(SumFor == SumFormula) Console.WriteLine("Same Results.");
		else Console.WriteLine("Results mismatched.");
	}
}
