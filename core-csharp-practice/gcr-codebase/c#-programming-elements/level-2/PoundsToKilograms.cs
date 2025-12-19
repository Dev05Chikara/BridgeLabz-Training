using System;
class PoundsToKilograms{
	static void Main(){
		Console.WriteLine("Enter Weight in Pounds:");
		double WeightInPounds= double.Parse(Console.ReadLine());
		
		double WeightInKg= WeightInPounds / 2.2;
		
		Console.WriteLine("The weight of the person in pounds is "+WeightInPounds+" and in kg is "+WeightInKg);
	}
}
