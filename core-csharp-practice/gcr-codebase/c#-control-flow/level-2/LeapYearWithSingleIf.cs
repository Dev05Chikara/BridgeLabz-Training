using System;
class LeapYearWithSingleIf{
	static void Main(){
		Console.Write("Enter the Year: ");
		int Year =int.Parse(Console.ReadLine());
		if(Year<1582) Console.WriteLine("Invalid Year.");
		else{
			if((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0)) Console.WriteLine("The year "+Year+" is a leap year.");
			else Console.WriteLine("The year "+Year+" is not a leap year.");
		}
	}
}