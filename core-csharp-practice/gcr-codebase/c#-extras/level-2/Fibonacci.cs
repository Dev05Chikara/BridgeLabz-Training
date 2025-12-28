using System;
class Fibonacci{
	static void Generate(int n){
		int a = 0, b = 1;
		for(int i = 1; i <= n; i++){
			Console.Write(a + " ");
			int c = a + b;
			a = b;
			b = c;
		}
	}
	static void Main(){
		Console.Write("Enter terms: ");
		int n = int.Parse(Console.ReadLine());
		Generate(n);
	}
}
