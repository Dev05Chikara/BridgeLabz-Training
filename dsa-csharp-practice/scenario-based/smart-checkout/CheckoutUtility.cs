using System;
using System.Collections.Generic;

class CheckoutUtility{
	Queue<Customer> queue= new Queue<Customer>();
	Dictionary<string, int> priceMap= new Dictionary<string, int>();
	Dictionary<string, int> stockMap= new Dictionary<string, int>();
	
	public CheckoutUtility(){
		priceMap.Add("Milk", 50);
		priceMap.Add("Bread", 40);
		priceMap.Add("Eggs", 60);
		
		stockMap.Add("Milk", 10);
		stockMap.Add("Bread", 10);
		stockMap.Add("Eggs", 10);
	}
	
	public void AddCustomer(Customer c){
		queue.Enqueue(c);
		Console.WriteLine(c.Name+" added to queue.");
	}
	
	public void ProcessCustomer(){
		if(queue.Count==0){
			Console.WriteLine("No customers in queue.");
			return;
		}
		Customer c= queue.Dequeue();
		int total=0;
		Console.WriteLine("\nBilling for "+c.Name);
		foreach(string item in c.Items){
			if(stockMap[item]>0){
				total+= priceMap[item];
				stockMap[item]--;
			}else{
				Console.WriteLine(item+" is out of stock.");
			}
		}
		Console.WriteLine("Total Bill: "+total);
	}
}
