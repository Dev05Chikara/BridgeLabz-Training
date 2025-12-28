using System;
class PrimeChecker{
	static bool IsPrime(int n){
		if(n <= 1) return false;
		for(int i = 2; i * i <= n; i++) if(n % i == 0) return false;
		return true;
	}
	static void Main(){
		Console.Write("Enter a number: ");
		int n = int.Parse(Console.ReadLine());
		if(IsPrime(n)) Console.WriteLine("Prime Number");
		else Console.WriteLine("Not a Prime Number");
	}
}
