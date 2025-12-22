using System;
class DivisibleByFive{
	static void Main(){
		Console.WriteLine("Please Enter The Number:");
		int Num=int.Parse(Console.ReadLine());
		if(Num % 5 == 0){
			Console.WriteLine("Is the number "+Num+" divisible by 5? YES.");
		}
		else{
			Console.WriteLine("Is the number "+Num+" divisible by 5? NO.");
		}
	}
}