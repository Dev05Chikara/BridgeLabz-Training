using System;
class DoubleOpt{
	static void Main(){
		Console.WriteLine("Enter First Value:");
		double a= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Value:");
		double b= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Third Value:");
		double c= double.Parse(Console.ReadLine());
		
		double Result1= a + b * c;
		double Result2= a * b + c;
		double Result3= c + a / b;
		double Result4= a % b + c;
		
		Console.WriteLine("The results of Double Operations are "+Result1+", "+Result2+", "+Result3+", and "+Result4);
	}
}
