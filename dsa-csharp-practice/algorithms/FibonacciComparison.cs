//Recursive vs Iterative Fibonacci
using System;
using System.Diagnostics;

class FibonacciComparison{
	static int FibonacciRecursive(int n){
		if(n<=1) return n;
		return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);
	}
	
	static int FibonacciIterative(int n){
		if(n<=1) return n;
		
		int a=0,b=1;
		for(int i=2;i<=n;i++){
			int sum= a+b;
			a= b;
			b= sum;
		}
		return b;
	}
	
	static void Main(){
		int n= 30;
		Stopwatch sw= new Stopwatch();
		
		sw.Start();
		FibonacciRecursive(n);
		sw.Stop();
		Console.WriteLine("Recursive Time: "+sw.ElapsedMilliseconds);
		
		sw.Restart();
		FibonacciIterative(n);
		sw.Stop();
		Console.WriteLine("Iterative Time: "+sw.ElapsedMilliseconds);
	}
}
