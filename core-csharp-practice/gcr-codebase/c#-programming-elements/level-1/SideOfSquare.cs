using System;
class SideOfSquare{
	static void Main(){
		Console.WriteLine("Enter Perimeter of Square:");
		double Perimeter= double.Parse(Console.ReadLine());
		double Side= Perimeter / 4;
		Console.WriteLine("The length of the side is "+Side+" whose perimeter is "+Perimeter);
	}
}
