using System;
class CanVote{
	static void Main(){
		Console.WriteLine("Please Enter Your Age:");
		int Age=int.Parse(Console.ReadLine());
		if(Age < 18){
			Console.WriteLine("The person's age is "+Age+" and cannot vote.");
		}else{
			Console.WriteLine("The person's age is "+Age+" and can vote.");
		}
	}
}