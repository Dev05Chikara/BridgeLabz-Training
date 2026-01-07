using System;
using System.Collections.Generic;

interface ITaxable{
	double CalculateTax();
	string GetTaxDetails();
}

abstract class Product{
	private int productId;
	private string name;
	public double price;

	public Product(int id, string name, double price){
		this.productId= id;
		this.name= name;
		this.price= price;
	}

	public abstract double CalculateDiscount();

	public void DisplayDetails(){
		Console.WriteLine("\nID: "+productId);
		Console.WriteLine("Name: "+name);
	}
}

class Electronics : Product, ITaxable{
	public Electronics(int id, string name, double price)
		: base(id, name, price){}

	public override double CalculateDiscount(){
		return price * 0.10;
	}

	public double CalculateTax(){
		return price * 0.18;
	}

	public string GetTaxDetails(){
		return "GST 18%";
	}
}

class Program{
	static void Main(){
		List<Product> products= new List<Product>();
		products.Add(new Electronics(1, "Laptop", 500000));
		products.Add(new Electronics(2, "Mobile", 120000));

		foreach(Product p in products){
			p.DisplayDetails();
			double finalPrice= ((Electronics)p).CalculateTax() + p.price - p.CalculateDiscount();
			Console.WriteLine("Final Price: "+finalPrice);
		}
	}
}
