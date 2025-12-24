using System;
class VotingEligibility{
	static void Main(){
		Console.WriteLine("Enter the Age's of all 10 Students:");
		int [] Ages= new int[10];
		for(int Age=0; Age<Ages.Length; Age++) Ages[Age]=int.Parse(Console.ReadLine());
		for(int Age=0; Age<Ages.Length; Age++){
			if(Ages[Age] < 0)Console.WriteLine("Invalid Age.");
			else if(Ages[Age] < 18)Console.WriteLine("The student with the age "+Ages[Age]+" cannot vote.");
			else Console.WriteLine("The student with the age "+Ages[Age]+" can vote.");
		}
	}
}