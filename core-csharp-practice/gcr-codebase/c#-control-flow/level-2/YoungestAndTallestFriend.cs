using System;
class YoungestAndTallestFriend{
	static void Main(){
		Console.WriteLine("Enter Age of Amar:");
		int AgeAmar = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Height of Amar:");
		double HeightAmar = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Age of Akbar:");
		int AgeAkbar = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Height of Akbar:");
		double HeightAkbar = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Age of Anthony:");
		int AgeAnthony = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Height of Anthony:");
		double HeightAnthony = double.Parse(Console.ReadLine());
		// Finding Youngest
		if(AgeAmar <= AgeAkbar && AgeAmar <= AgeAnthony) Console.WriteLine("Amar is the youngest.");
		else if(AgeAkbar <= AgeAmar && AgeAkbar <= AgeAnthony) Console.WriteLine("Akbar is the youngest.");
		else Console.WriteLine("Anthony is the youngest.");
		// Finding Tallest
		if(HeightAmar >= HeightAkbar && HeightAmar >= HeightAnthony) Console.WriteLine("Amar is the tallest.");
		else if(HeightAkbar >= HeightAmar && HeightAkbar >= HeightAnthony) Console.WriteLine("Akbar is the tallest.");
		else Console.WriteLine("Anthony is the tallest.");
	}
}
