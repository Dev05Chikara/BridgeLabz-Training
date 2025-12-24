using System;
class FootballTeam{
	static void Main(){
		Console.WriteLine("Enter the Height of all 11 Players(in cm):");
		double[] Height= new double[11];
		double Sum= 0.0;
		for(int i=0; i<Height.Length; i++){
			Height[i]= double.Parse(Console.ReadLine());
			Sum += Height[i];
		}
		double Mean= Sum / Height.Length;
		Console.WriteLine("The mean height of the Football team is "+Mean+" cm");
	}
}