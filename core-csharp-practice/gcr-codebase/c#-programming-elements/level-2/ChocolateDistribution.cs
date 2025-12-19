using System;
class ChocolateDistribution{
	static void Main(){
		Console.WriteLine("Enter Number of Chocolates:");
		int NumberOfChocolates= int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Number of Children:");
		int NumberOfChildren= int.Parse(Console.ReadLine());
		
		int ChocolatesPerChild= NumberOfChocolates / NumberOfChildren;
		int RemainingChocolates= NumberOfChocolates % NumberOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is "+ChocolatesPerChild+" and the number of remaining chocolates is "+RemainingChocolates);
	}
}
