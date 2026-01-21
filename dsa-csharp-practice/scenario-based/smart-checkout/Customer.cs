using System.Collections.Generic;

class Customer{
	public string Name;
	public List<string> Items;
	
	public Customer(string name){
		Name= name;
		Items= new List<string>();
	}
}
