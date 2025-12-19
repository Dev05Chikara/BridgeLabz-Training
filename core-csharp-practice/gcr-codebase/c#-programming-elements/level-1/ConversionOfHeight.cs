using System;
class ConversionOfHeight{
	static void Main(){
		Console.WriteLine("Enter Your Height in cm :");
		double HeightInCm= double.Parse(Console.ReadLine());
		double HeightInInches= HeightInCm / 2.54;
		double HeightInFeet= HeightInInches / 12;
		Console.WriteLine("Your Height in cm is "+HeightInCm+" while in feet is "+HeightInFeet+" and inches is "+HeightInInches);
	}
}