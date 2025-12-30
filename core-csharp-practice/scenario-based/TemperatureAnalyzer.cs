using System;
class TemperatureAnalyzer{
	static void Analyze(float[,] temp){
		int hottestDay=0, coldestDay=0;
		float maxAvg=float.MinValue, minAvg=float.MaxValue;
		for(int day=0;day<7;day++){
			float sum=0;
			for(int hour=0;hour<24;hour++){
				sum+=temp[day,hour];
			}
			float avg=sum/24;
			Console.WriteLine("Day "+(day+1)+" Average: "+avg);
			if(avg>maxAvg){
				maxAvg=avg;
				hottestDay=day;
			}
			if(avg<minAvg){
				minAvg=avg;
				coldestDay=day;
			}
		}
		Console.WriteLine("\nHottest Day: Day "+(hottestDay+1));
		Console.WriteLine("Coldest Day: Day "+(coldestDay+1));
	}

	static void Main(){
		float[,] temp=new float[7,24];
		Console.WriteLine("Enter temperatures for 7 days(Hours-wise)");
		for(int i=0;i<7;i++){
			Console.WriteLine("Day "+(i+1));
			for(int j=0;j<24;j++){
				while(!float.TryParse(Console.ReadLine(),out temp[i,j])){
					Console.WriteLine("Invalid input. Enter again:");
				}
			}
		}
		Analyze(temp);
	}
}
