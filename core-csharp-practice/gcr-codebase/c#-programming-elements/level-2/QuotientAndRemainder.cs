using System;
class QuotientAndRemainder{
	static void Main(){
		Console.WriteLine("Enter First Number:");
		int Number1= int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		int Number2= int.Parse(Console.ReadLine());
		int Quotient= Number1 / Number2;
		int Remainder= Number1 % Number2;
		Console.WriteLine("The Quotient is "+Quotient+" and Remainder is "+Remainder+" of two numbers "+Number1+" and "+Number2);
	}
}
