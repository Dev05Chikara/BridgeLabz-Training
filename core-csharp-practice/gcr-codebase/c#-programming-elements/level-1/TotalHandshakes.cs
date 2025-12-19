using System;
class TotalHandshakes{
	static void Main(){
		Console.WriteLine("Enter Number of Students:");
		int NumberOfStudents= int.Parse(Console.ReadLine());
		int Handshakes= (NumberOfStudents * (NumberOfStudents - 1)) / 2;
		Console.WriteLine("The maximum number of possible handshakes is "+Handshakes);
	}
}
