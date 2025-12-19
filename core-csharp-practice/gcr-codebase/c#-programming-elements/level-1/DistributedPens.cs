using System;
class DistributedPens{
	static void Main(){
		int Pens= 14;
		int Students= 3;
		int GettingPens= Pens/Students; //Per Student Pens...
		int RemainingPens= Pens%Students; //Non-Distributed Pens...
		Console.WriteLine("The Pen Per Student is "+GettingPens+" and the remaining pen not distributed is "+RemainingPens);
	}
}