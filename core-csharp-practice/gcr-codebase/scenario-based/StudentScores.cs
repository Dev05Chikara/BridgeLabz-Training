using System;
class StudentScores{
	static void Main(){
		Console.WriteLine("Enter number of students:");
		int n;
		while(!int.TryParse(Console.ReadLine(),out n) || n<=0){
			Console.WriteLine("Invalid number. Enter again:");
		}
		float[] scores=new float[n];
		float sum=0;
		for(int i=0;i<n;i++){
			Console.Write("Score of student "+(i+1)+": ");
			while(true){
				if(float.TryParse(Console.ReadLine(),out scores[i]) && scores[i]>=0){
					break;
				}
				Console.WriteLine("Invalid score. Enter again:");
			}
			sum+=scores[i];
		}
		float avg=sum/n;
		float max=scores[0], min=scores[0];
		for(int i=1;i<n;i++){
			if(scores[i]>max) max=scores[i];
			if(scores[i]<min) min=scores[i];
		}
		Console.WriteLine("\nAverage Score: "+avg);
		Console.WriteLine("Highest Score: "+max);
		Console.WriteLine("Lowest Score: "+min);
		Console.WriteLine("\nScores Above Average:");
		for(int i=0;i<n;i++){
			if(scores[i]>avg){
				Console.WriteLine(scores[i]);
			}
		}
	}
}
