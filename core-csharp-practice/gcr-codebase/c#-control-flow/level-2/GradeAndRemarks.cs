using System;
class GradeAndRemarks{
	static void Main(){
		Console.WriteLine("Enter the Marks");
		Console.Write("Physics: ");
		double Physics=double.Parse(Console.ReadLine());
		Console.Write("Chemistry: ");
		double Chemistry=double.Parse(Console.ReadLine());
		Console.Write("Maths: ");
		double Maths=double.Parse(Console.ReadLine());
		double Avg= (Physics + Chemistry + Maths)/3;
		Console.WriteLine("Average Marks: "+Avg);
		if(Avg>=80){
			Console.WriteLine("Grade: A");
			Console.WriteLine("Remarks: Level 4, above agency-normalized standards");
		}
		else if(Avg>=70){
			Console.WriteLine("Grade: B");
			Console.WriteLine("Remarks: Level 3, at agency-normalized standards");
		}
		else if(Avg>=60){
			Console.WriteLine("Grade: C");
			Console.WriteLine("Remarks: Level 2, below but approaching agency-normalized standards");
		}
		else if(Avg>=50){
			Console.WriteLine("Grade: D");
			Console.WriteLine("Remarks: Level 1, well below agency-normalized standards");
		}
		else if(Avg>=40){
			Console.WriteLine("Grade: E");
			Console.WriteLine("Remarks: Level 1-, too below agency-normalized standards");
		}
		else{
			Console.WriteLine("Grade: R");
			Console.WriteLine("Remarks: Remedial standards");
		}
	}
}