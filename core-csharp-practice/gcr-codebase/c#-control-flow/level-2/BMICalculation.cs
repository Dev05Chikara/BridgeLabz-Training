using System;
class BMICalculation{
	static void Main(){
		Console.WriteLine("Enter Weight in kg:");
		double Weight = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Height in cm:");
		double HeightInCm = double.Parse(Console.ReadLine());
		double HeightInMeter = HeightInCm/100;
		double BMI = Weight/(HeightInMeter * HeightInMeter);
		Console.WriteLine("Your BMI is: " + BMI);
		if(BMI <= 18.4)
			Console.WriteLine("Status: Underweight");
		else if(BMI >= 18.5 && BMI <= 24.9)
			Console.WriteLine("Status: Normal");
		else if(BMI >= 25.0 && BMI <= 39.9)
			Console.WriteLine("Status: Overweight");
		else
			Console.WriteLine("Status: Obese");
	}
}
