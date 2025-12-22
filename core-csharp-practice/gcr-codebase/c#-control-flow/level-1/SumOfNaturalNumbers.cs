using System;
class SumOfNaturalNumbers{
	static void Main(){
		Console.WriteLine("Please Enter The Number:");
		int Num=int.Parse(Console.ReadLine());
		if(Num < 0){
			Console.WriteLine("The number "+Num+" is not a natural number");
		}
		else{
			int Sum=(Num*(Num+1))/2;
			Console.WriteLine("The sum of "+Num+" natural numbers is "+Sum);
		}
	}
}