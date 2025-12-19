using System;
class Operators{
	static void Main(){
		int a=2; //First integer
		int b=3; //Second integer
		
		//Arithmetic operators...
		Console.WriteLine(a+b); //Addition
		Console.WriteLine(b-a); //Substraction
		Console.WriteLine(a*b); //Multiplication
		Console.WriteLine(b/a); //Division
		Console.WriteLine(b%a); //Modulus
		
		//Relational Operators...
		Console.WriteLine(a==b); //Equal to
		Console.WriteLine(b!=a); //Not equal
		Console.WriteLine(b>a); //Greater
		Console.WriteLine(b<a); //Lesser
		Console.WriteLine(a>=b); //Greater and equal
		Console.WriteLine(a<=b); //Lesser and equal
		
		//Logical Operators...
		bool x= true;
		bool y= false;
		Console.WriteLine(x && y); //Logical AND
		Console.WriteLine(x || y); //Logical OR 
		Console.WriteLine(!x); //Logical NOT (!)
		
		//Assignment Operators...
		// Assignment(=)
		a= 10;
		b= 5;
		a += b; // a=a+b (Addition assignment)
		Console.WriteLine(a);
		a -= b; // a=a-b (Subtraction assignment)
		Console.WriteLine(a);
		a *= b; // a=a*b (Multiplication assignment)
		Console.WriteLine(a);
		a /= b; // a=a/b (Division assignment)
		Console.WriteLine(a);
		a %= b; // a=a%b (Modulus assignment)
		Console.WriteLine(a);
		
		//Unary Operators...
		a = 5;
		Console.WriteLine(a);
		Console.WriteLine(++a); // Pre-increment
		Console.WriteLine(a++); // Post-increment
		Console.WriteLine(a);
		Console.WriteLine(--a); // Pre-decrement
		Console.WriteLine(a--); // Post-decrement
		Console.WriteLine(a); 
		
		//Bitwise Operators...
		a = 3; 
		b = 7; 

		Console.WriteLine(a & b); //AND
		Console.WriteLine(a | b); //OR
		Console.WriteLine(a ^ b); //XOR
		Console.WriteLine(~a); //Complement
		Console.WriteLine(a << 1); //Left Shift
		Console.WriteLine(a >> 1); //Right Shift
		
		//Ternary Operator...
		a = 10;
		b = 20;
		int min = (a < b) ? a : b;
		Console.WriteLine(min);
		
		//is Operator
		int d=3;
		Console.WriteLine(d is int);
	}
}