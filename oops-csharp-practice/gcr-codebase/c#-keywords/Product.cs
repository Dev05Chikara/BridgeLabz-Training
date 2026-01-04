using System;
class Product{
	public static int Discount= 10;
	
	public readonly int ProductID;
	private string ProductName;
	private int Price;
	private int Quantity;
	
	public Product(int ProductID, string ProductName, int Price, int Quantity){
		this.ProductID= ProductID;
		this.ProductName= ProductName;
		this.Price= Price;
		this.Quantity= Quantity;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nProduct Details:");
		Console.WriteLine("ID: "+ProductID);
		Console.WriteLine("Name: "+ProductName);
		Console.WriteLine("Price: "+Price);
		Console.WriteLine("Quantity: "+Quantity);
		Console.WriteLine("Discount: "+Discount+"%");
	}
	
	public static void UpdateDiscount(int newDiscount){
		Discount= newDiscount;
	}
}
class Program{
	static void Main(){
		object prod= new Product(1, "Laptop", 60000, 1);
		
		if(prod is Product){
			((Product)prod).DisplayDetails();
		}
		
		Product.UpdateDiscount(15);
	}
}
