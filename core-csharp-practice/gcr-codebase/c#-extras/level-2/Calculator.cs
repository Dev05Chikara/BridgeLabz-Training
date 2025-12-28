using System;
class Calculator{
	static double Add(double a, double b){ return a + b; }
	static double Sub(double a, double b){ return a - b; }
	static double Mul(double a, double b){ return a * b; }
	static double Div(double a, double b){ return a / b; }
	static void Main(){
		Console.WriteLine("Enter two numbers: ");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		Console.Write("Choose operation (+, -, *, or /): ");
		char op = Console.ReadLine()[0];
		if(op == '+') Console.WriteLine(Add(a, b));
		else if(op == '-') Console.WriteLine(Sub(a, b));
		else if(op == '*') Console.WriteLine(Mul(a, b));
		else if(op == '/') Console.WriteLine(Div(a, b));
		else Console.WriteLine("Invalid Operation");
	}
}
