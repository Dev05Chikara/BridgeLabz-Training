using System;
class IntOperation{
	static void Main(){
		Console.WriteLine("Enter First Value:");
		int a= int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Value:");
		int b= int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Third Value:");
		int c= int.Parse(Console.ReadLine());
		
		int Result1= a + b * c;
		int Result2= a * b + c;
		int Result3= c + a / b;
		int Result4= a % b + c;
		
		Console.WriteLine("The results of Int Operations are "+Result1+", "+Result2+", "+Result3+", and "+Result4);
	}
}
