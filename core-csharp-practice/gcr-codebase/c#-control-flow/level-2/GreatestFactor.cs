using System;
class GreatestFactor{
	static void Main(){
		Console.WriteLine("Enter a number:");
		int Number = int.Parse(Console.ReadLine());
		int GreatestFactor = 1;
		for(int i = Number - 1; i >= 1; i--){
			if(Number % i == 0){
				GreatestFactor = i;
				break;
			}
		}
		Console.WriteLine("Greatest Factor (beside itself): " + GreatestFactor);
	}
}
