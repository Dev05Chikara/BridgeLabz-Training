using System;
class PrimeNumber{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int Number = int.Parse(Console.ReadLine());
		if(Number <= 1){
			Console.WriteLine("Not a Prime Number");
		}
		bool isPrime = true;
		for(int i=2; i<Number; i++){
			if(Number%i == 0){
				isPrime = false;
				break;
			}
		}
		if(isPrime)
			Console.WriteLine(Number+" is a Prime Number.");
		else
			Console.WriteLine(Number+" is not a Prime Number.");
	}
}
