using System;
class Bill{
	public static void GenerateBill(IPayable p){
		Console.WriteLine("Final Payable Amount: "+p.CalculateBill());
	}
}
