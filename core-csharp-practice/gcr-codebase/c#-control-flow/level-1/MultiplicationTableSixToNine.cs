using System;
class MultiplicationTableSixToNine{
	static void Main(){
		Console.WriteLine("Enter the Number:");
		int Number= int.Parse(Console.ReadLine());
		for(int i=6; i<= 9; i++) Console.WriteLine(Number+" * "+i+" = "+(Number * i));
	}
}
