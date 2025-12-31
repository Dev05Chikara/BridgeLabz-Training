using System;
class Mathmathity{
	public void Factorial(int number){
		if(number < 0){
			Console.WriteLine("Factorial is Undefined for Negative values.");
			return;
		}
		long result= 1;
		for(int i=1; i<=number; i++) result*=i;
		Console.WriteLine("Factorial of "+number+": "+result);
	}
	
	public void Prime(int number){
		if(number <= 1){
			Console.WriteLine(number+": not a Prime number");
			return;
		}
		int count= 0;
		for(int i=2; i<=(number/2); i++) if(number%i == 0) count++;
		if(count == 0) Console.WriteLine(number+": Prime number");
		else Console.WriteLine(number+": not a Prime number");
	} 
	
	public void GCD(int first, int second){
		if(first<0) first= -first;
		if(second<0) second= -second;
		int limit= Math.Min(first, second);
		if(limit == 0){
			Console.WriteLine("GCD of "+first+" and "+second+" is "+Math.Max(first, second));
			return;
		}
		int gcd=1;
		for(int i=2; i<= limit; i++) if((first%i == 0) && (second%i == 0)) gcd= i;
		Console.WriteLine("GCD of "+first+" and "+second+" is "+gcd);
	}
	
	public void Fibonacci(int number){
		if(number<0){
			Console.WriteLine("Fibonacci is not defined for negative numbers.");
			return;
		}
		if(number==0){
			Console.WriteLine("Fibonacci of "+number+" is 0");
			return;
		}
		if(number==1){
			Console.WriteLine("Fibonacci of "+number+" is 1");
			return;
		}
		int first= 0;
		int second= 1;
		int fibonacci= 0;
		for(int i=2; i<=number; i++){
			fibonacci= first+second;
			first= second;
			second= fibonacci;
		}
		Console.WriteLine("Fibonacci of "+number+" is "+fibonacci);
	}
}

class Program{
	static void Main(){
		Mathmathity math= new Mathmathity();
		Console.WriteLine("=== Testing Math mathity Class ===\n");
        // Factorial Tests
        Console.WriteLine("Factorial Tests:");
        math.Factorial(5);
        math.Factorial(0);
        math.Factorial(-3);
        // Prime Tests
        Console.WriteLine("\nPrime Number Tests:");
        math.Prime(7);
        math.Prime(1);
        math.Prime(-5);
        // GCD Tests
        Console.WriteLine("\nGCD Tests:");
        math.GCD(24, 36);
        math.GCD(-20, 30);
        math.GCD(0, 10);
        // Fibonacci Tests
        Console.WriteLine("\nFibonacci Tests:");
        math.Fibonacci(7);
        math.Fibonacci(0);
        math.Fibonacci(-4);
		
        Console.WriteLine("\n=== Program Execution Completed ===");
	}
}