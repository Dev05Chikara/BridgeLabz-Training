using System;
class SmallestOfTheThreeNumbers{
	static void Main(){
		Console.WriteLine("Enter The First Number:");
		int Number1=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter The Second Number:");
		int Number2=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter The Third Number:");
		int Number3=int.Parse(Console.ReadLine());
		if(Number1 < Number2 && Number1 < Number3){
			Console.WriteLine("Is the first number "+Number1+" the smallest? YES.");
		}else{
			Console.WriteLine("Is the first number "+Number1+" the smallest? NO.");
		}
	}
}