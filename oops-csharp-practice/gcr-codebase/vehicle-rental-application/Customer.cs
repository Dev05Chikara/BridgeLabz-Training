using System;
class Customer{
	public string name;
	public int days;
	
	public Customer(string name, int days){
		this.name= name;
		this.days= days;
	}
	
	public void DisplayCustomer(){
		Console.WriteLine("Customer Name: "+name);
		Console.WriteLine("Rental Days: "+days);
	}
}
