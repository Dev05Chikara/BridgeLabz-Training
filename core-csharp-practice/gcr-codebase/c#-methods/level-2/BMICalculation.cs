using System;
class BMICalculation{
    static void CalculateBMI(double[,] Data){
        for(int i=0;i<10;i++){
            double HeightMeter = Data[i,1] / 100;
            Data[i,2] = Data[i,0] / (HeightMeter * HeightMeter);
        }
    }
    static string[] FindStatus(double[,] Data){
        string[] Status = new string[10];
        for(int i=0;i<10;i++){
            double Bmi = Data[i,2];
            if(Bmi <= 18.4) Status[i] = "Underweight";
            else if(Bmi <= 24.9) Status[i] = "Normal";
            else if(Bmi <= 39.9) Status[i] = "Overweight";
            else Status[i] = "Obese";
        }
        return Status;
    }
    static void Main(){
        double[,] Data = new double[10,3];
        for(int i=0;i<10;i++){
			Console.Write("Enter Weight(kg) of member "+(i+1)+": ");
            Data[i,0] = double.Parse(Console.ReadLine());
			Console.Write("Enter Height(cm) of member "+(i+1)+": ");
            Data[i,1] = double.Parse(Console.ReadLine());
        }
        CalculateBMI(Data);
        string[] Status = FindStatus(Data);
		Console.WriteLine("Details of all 10 Members");
        for(int i=0;i<10;i++) {
			Console.Write("Member "+(i+1)+": ");
			Console.WriteLine("Weight= "+Data[i,0]+" kg, Height= "+Data[i,1]+" cm, BMI= "+Data[i,2]+" , Status= "+Status[i]);
		}
    }
}
