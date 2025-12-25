using System;
class StudentScoreCard{
    static int[,] GeneratePCMScores(int Students){
        int[,] Scores=new int[Students,3];
        Random R=new Random();
        for(int i=0;i<Students;i++){
            Scores[i,0]=R.Next(10,100);
            Scores[i,1]=R.Next(10,100);
            Scores[i,2]=R.Next(10,100);
        }
        return Scores;
    }
    static double[,] CalculateResult(int[,] Scores){
        int Students=Scores.GetLength(0);
        double[,] Result=new double[Students,3];
        for(int i=0;i<Students;i++){
            int Total=Scores[i,0]+Scores[i,1]+Scores[i,2];
            double Avg=(double)Total/3;
            double Percent=(double)Total/300*100;
            Result[i,0]=Total;
            Result[i,1]=Math.Round(Avg,2);
            Result[i,2]=Math.Round(Percent,2);
        }
        return Result;
    }
    static void DisplayScoreCard(int[,] Scores,double[,] Result){
        Console.WriteLine("Stu\tPhy\tChem\tMath\tTotal\tAvg\tPercent");
        for(int i=0;i<Scores.GetLength(0);i++){
            Console.WriteLine((i+1)+"\t"+Scores[i,0]+"\t"+Scores[i,1]+"\t"+Scores[i,2]+"\t"+Result[i,0]+"\t"+Result[i,1]+"\t"+Result[i,2]);
        }
    }
    static void Main(){
        Console.Write("Enter number of students: ");
        int Students=int.Parse(Console.ReadLine());
        int[,] Scores=GeneratePCMScores(Students);
        double[,] Result=CalculateResult(Scores);
        DisplayScoreCard(Scores,Result);
    }
}
