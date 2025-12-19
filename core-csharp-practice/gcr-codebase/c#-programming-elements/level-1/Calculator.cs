using System;
class Calculator{
	static void Main(){
		Console.WriteLine("Enter First Number:");
		double Number1= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		double Number2= double.Parse(Console.ReadLine());
		double Add= Number1 + Number2;
		double Subs= Number1 - Number2;
		double Mul= Number1 * Number2;
		double Div= Number1 / Number2;
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+Number1+" and "+Number2+" is "+Add+", "+Subs+", "+Mul+", and "+Div);
	}
}