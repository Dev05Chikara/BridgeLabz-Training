using System;
class NatureOfNumber{
	static void Main(){
		Console.WriteLine("Please Enter The Number:");
		int Num=int.Parse(Console.ReadLine());
		if(Num>0)Console.WriteLine("The number "+Num+" is Positive.");
		else if(Num<0)Console.WriteLine("The number "+Num+" is Negative.");
		else Console.WriteLine("The number "+Num+" is Zero.");	
	}
}