using System;
class SpringSeason {
	static void Main(){
		Console.WriteLine("Please enter the Month:");
		int Month =int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the Day:");
		int Day =int.Parse(Console.ReadLine());
		if(Month<3 && Month>6) Console.WriteLine("It's not a Spring Season.");
		else if((Month==3 && Day<20) || (Month==6 && Day>20)) Console.WriteLine("It's not a Spring Season.");
		else{
			if((Month== 3 || Month==5) && (Day<1 || Day>31))Console.WriteLine("Please enter valid Day.");
			else if ((Month== 4 || Month==6) && (Day<1 || Day>30))Console.WriteLine("Please enter valid Day.");
			else Console.WriteLine("It's  a Spring Season.");
		}
	}
}