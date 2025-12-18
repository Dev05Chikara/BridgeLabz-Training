using System;
class simple_interest{
	static void Main(){
		double principal = 2000; //Principal given
		double rate = 2.5; //Defined rate
		double time = 0.5; //Time-period
		double si = (principal * rate * time) / 100; //Calculate SI
		Console.WriteLine(si);
	}
}