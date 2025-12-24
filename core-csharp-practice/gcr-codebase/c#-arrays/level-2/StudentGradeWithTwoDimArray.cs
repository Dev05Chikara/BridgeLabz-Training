using System;
class StudentGradeWithTwoDimArray{
	static void Main(){
		Console.Write("Enter number of Students: ");
		int Students=Convert.ToInt32(Console.ReadLine());
		double[,] Marks=new double[Students,3];
		double[] Percentage=new double[Students];
		string[] Grade=new string[Students];
		for(int i=0;i<Students;i++){
			Console.WriteLine("Enter marks of Student "+(i+1));
			Console.Write("Physics: ");
			double Physics=Convert.ToDouble(Console.ReadLine());
			if(Physics<0) i--;
			Console.Write("Chemistry: ");
			double Chemistry=Convert.ToDouble(Console.ReadLine());
			if(Chemistry<0) i--;
			Console.Write("Maths: ");
			double Maths=Convert.ToDouble(Console.ReadLine());
			if(Maths<0) i--;
			Marks[i,0]=Physics;
			Marks[i,1]=Chemistry;
			Marks[i,2]=Maths;
		}
		for(int i=0;i<Students;i++){
			double Total=Marks[i,0]+Marks[i,1]+Marks[i,2];
			Percentage[i]=(Total/300)*100;
			if(Percentage[i]>=80) Grade[i]="A";
			else if(Percentage[i]>=70) Grade[i]="B";
			else if(Percentage[i]>=60) Grade[i]="C";
			else if(Percentage[i]>=50) Grade[i]="D";
			else if(Percentage[i]>=40) Grade[i]="E";
			else Grade[i]="R";
		}
		for(int i=0;i<Students;i++){
			Console.WriteLine("Student "+(i+1));
			Console.WriteLine("Physics="+Marks[i,0]+" Chemistry="+Marks[i,1]+" Maths="+Marks[i,2]);
			Console.WriteLine("Percentage="+Percentage[i]+" Grade="+Grade[i]);
		}
	}
}
