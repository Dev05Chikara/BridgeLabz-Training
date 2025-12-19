using System;
class AreaOfTriangle{
	static void Main(){
		Console.WriteLine("Enter Base of Triangle in cm:");
		double Base= double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Height of Triangle in cm:");
		double Height= double.Parse(Console.ReadLine());
		double AreaInCm= (0.5 * Height) * Base;
		double AreaInInches= AreaInCm / (2.54 * 2.54);
		double AreaInFeet= AreaInInches / (144);
		Console.WriteLine("Area of Triangle in cm is "+AreaInCm+" while in feet is "+AreaInFeet+" and inches is "+AreaInInches);
	}
}