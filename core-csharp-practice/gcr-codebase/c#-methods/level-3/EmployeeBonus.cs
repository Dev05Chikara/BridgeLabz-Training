using System;
class EmployeeBonus{
    static int[,] GenerateEmployeeData(){
        int[,] Data=new int[10,2];
        Random R=new Random();
        for(int i=0;i<10;i++){
            Data[i,0]=R.Next(10000,100000);
            Data[i,1]=R.Next(1,11);
        }
        return Data;
    }
    static double[,] CalculateNewSalaryAndBonus(int[,] Data){
        double[,] Result=new double[10,2];
        for(int i=0;i<10;i++){
            int Salary=Data[i,0];
            int Years=Data[i,1];
            double Bonus;
            if(Years>5) Bonus=Salary*0.05;
            else Bonus=Salary*0.02;
            Result[i,0]=Salary+Bonus;
            Result[i,1]=Bonus;
        }
        return Result;
    }
    static void DisplayTotals(int[,] Data,double[,] Result){
        double OldSum=0,NewSum=0,BonusSum=0;
        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\tNewSalary");
        for(int i=0;i<10;i++){
            OldSum+=Data[i,0];
            NewSum+=Result[i,0];
            BonusSum+=Result[i,1];
            Console.WriteLine((i+1)+"\t"+Data[i,0]+"\t\t"+Data[i,1]+"\t"+Result[i,1]+"\t"+Result[i,0]);
        }
        Console.WriteLine("Total\t"+OldSum+"\t\t-\t"+BonusSum+"\t"+NewSum);
    }
    static void Main(){
        int[,] Data=GenerateEmployeeData();
        double[,] Result=CalculateNewSalaryAndBonus(Data);
        DisplayTotals(Data,Result);
    }
}
