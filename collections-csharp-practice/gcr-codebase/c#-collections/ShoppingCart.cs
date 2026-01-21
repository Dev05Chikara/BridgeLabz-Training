using System;
using System.Collections.Generic;

class ShoppingCart{
	static void Main(){
		Dictionary<string,double> cart= new Dictionary<string,double>();
		cart["Shoes"]=2000;
		cart["Bag"]=1500;
		foreach(var kv in cart)
			Console.WriteLine(kv.Key+" : "+kv.Value);
	}
}
