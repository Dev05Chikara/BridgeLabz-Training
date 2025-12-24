using System;
class BMICalculationTwoDimArray{
	static void Main(){
		Console.Write("Enter number of Persons: ");
		int Number= Convert.ToInt32(Console.ReadLine());
		double[][] PersonData= new double[Number][];
		string[] WeightStatus= new string[Number];
		for(int i=0;i<Number;i++){
			PersonData[i]=new double[3];
			Console.WriteLine("Enter details of Person "+(i+1));
			double Weight;
			do{
				Console.Write("Enter Weight in kg: ");
				Weight=double.Parse(Console.ReadLine());
			}while(Weight<=0);
			double HeightCm;
			do{
				Console.Write("Enter Height in cm: ");
				HeightCm=double.Parse(Console.ReadLine());
			}while(HeightCm<=0);
			double HeightMeter= HeightCm/100;
			double BMI= Weight/(HeightMeter*HeightMeter);
			PersonData[i][0]= Weight;
			PersonData[i][1]= HeightMeter;
			PersonData[i][2]= BMI;
			if(BMI<=18.4) WeightStatus[i]="Underweight";
			else if(BMI<=24.9) WeightStatus[i]="Normal";
			else if(BMI<=39.9) WeightStatus[i]="Overweight";
			else WeightStatus[i]="Obese";
		}
		for(int i=0;i<Number;i++){
			Console.WriteLine("Details of Person "+(i+1));
			Console.WriteLine("Weight="+PersonData[i][0]+", Height="+PersonData[i][1]+"m, BMI="+PersonData[i][2].ToString("0.00")+", Status="+WeightStatus[i]);
		}
	}
}
