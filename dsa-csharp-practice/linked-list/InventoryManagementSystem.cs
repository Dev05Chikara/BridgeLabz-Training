using System;

class InventoryManagementSystem{
	public int Id;
	public string Name;
	public int Qty;
	public double Price;
	public InventoryManagementSystem next;
	
	static InventoryManagementSystem head= null;
	
	public static void AddInventoryManagementSystem(){
		InventoryManagementSystem i= new InventoryManagementSystem();
		
		Console.Write("Enter InventoryManagementSystem ID: ");
		i.Id= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Name: ");
		i.Name= Console.ReadLine();
		
		Console.Write("Enter Quantity: ");
		i.Qty= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Price: ");
		i.Price= Convert.ToDouble(Console.ReadLine());
		
		i.next= head;
		head= i;
		
		Console.WriteLine("InventoryManagementSystem added.\n");
	}
	
	public static void TotalValue(){
		double sum= 0;
		InventoryManagementSystem temp= head;
		
		while(temp!= null){
			sum+= temp.Qty * temp.Price;
			temp= temp.next;
		}
		Console.WriteLine("Total Inventory Value: "+sum);
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---INVENTORY MENU---");
			Console.WriteLine("1. Add InventoryManagementSystem");
			Console.WriteLine("2. Total Value");
			Console.WriteLine("3. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: InventoryManagementSystem.AddInventoryManagementSystem(); break;
				case 2: InventoryManagementSystem.TotalValue(); break;
				case 3: menu= false; break;
			}
		}while(menu== true);
	}
}
