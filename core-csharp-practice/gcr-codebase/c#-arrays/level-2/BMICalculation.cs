using System;
class BMICalculation{
	static void Main(){
		Console.Write("Enter number of Persons: ");
		int Persons= Convert.ToInt32(Console.ReadLine());
		string [,] Table= new string[Persons, 4];
		for(int i=0; i<Persons; i++){
			Console.WriteLine("\nEnter details of Person "+(i+1));
			Console.Write("Enter Weight in kg: ");
			double Weight= double.Parse(Console.ReadLine());
			Table[i,0]= Weight.ToString();
			Console.Write("Enter Height in cm: ");
			double HeightInCm = double.Parse(Console.ReadLine());
			double HeightInMeter = HeightInCm/100;
			Table[i,1]= HeightInMeter.ToString();
			double BMI = Weight/(HeightInMeter * HeightInMeter);
			Table[i,2]= BMI.ToString();
			if(BMI <= 18.4) Table[i,3]= "Underweight";
			else if(BMI >= 18.5 && BMI <= 24.9) Table[i,3]= "Normal";
			else if(BMI >= 25.0 && BMI <= 39.9) Table[i,3]= "Overweight";
			else Table[i,3]= "Obese";				
		}
		for(int i=0; i<Persons; i++){
			Console.WriteLine("\nDetails of Person "+(i+1));
			Console.WriteLine("Weight= "+Table[i,0]+", Height= "+Table[i,1]+"m, BMI= "+Table[i,2]+", Status= "+Table[i,3]);			
		}
	}
}