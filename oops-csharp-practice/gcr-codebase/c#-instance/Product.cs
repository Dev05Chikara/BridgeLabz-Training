using System;
class Product{
	private string productName;
	private int price;
	public static int totalProducts= 0;
	
	public Product(string productName, int price){
		this.productName= productName;
		this.price= price;
		totalProducts++;
	}
	
	public void DisplayProductDetails(){
		Console.WriteLine("\nProduct Details:");
		Console.WriteLine("- Name: "+productName);
		Console.WriteLine("- Price: "+price);
	}
	
	public static void DisplayTotalProducts(){
		Console.WriteLine("\nTotal Products Created: "+totalProducts);
	}
}
class Program{
	static void Main(){
		Product p1= new Product("Laptop", 60000);
		Product p2= new Product("Mouse", 800);
		
		p1.DisplayProductDetails();
		p2.DisplayProductDetails();
		
		Product.DisplayTotalProducts();
	}
}
