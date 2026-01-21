using System;
using System.Collections.Generic;

class BankingSystem{
	static void Main(){
		Dictionary<int,double> accounts= new Dictionary<int,double>();
		accounts[101]=5000;
		accounts[102]=2000;
		SortedDictionary<int,double> sorted= new SortedDictionary<int,double>(accounts);
		
		Queue<int> withdraw= new Queue<int>();
		withdraw.Enqueue(101);
		
		int acc= withdraw.Dequeue();
		accounts[acc]-=1000;
		
		Console.WriteLine("Balance: "+accounts[acc]);
	}
}
