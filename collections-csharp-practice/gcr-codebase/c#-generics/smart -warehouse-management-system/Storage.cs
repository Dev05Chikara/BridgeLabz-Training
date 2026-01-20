using System;
using System.Collections.Generic;
class Storage<T> where T : WarehouseItem{
	List<T> items= new List<T>();
	
	public void AddItem(T item){
		items.Add(item);
		Console.WriteLine(item.name+" added successfully.");
	}
	
	public void DisplayItems(){
		if(items.Count==0){
			Console.WriteLine("No items in storage.");
			return;
		}
		
		Console.WriteLine("\n--- Warehouse Items ---");
		foreach(T item in items){
			Console.WriteLine(item.GetDetails());
		}
		Console.WriteLine("------------------------");
	}
}
