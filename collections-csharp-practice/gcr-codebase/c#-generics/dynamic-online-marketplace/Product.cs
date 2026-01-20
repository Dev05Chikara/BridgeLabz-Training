using System;
class Product<T> where T : Category{
	string productName;
	double price;
	T category;
	
	public Product(string productName, double price, T category){
		this.productName= productName;
		this.price= price;
		this.category= category;
	}
	
	public double GetPrice(){
		return price;
	}
	
	public void SetPrice(double price){
		this.price= price;
	}
	
	public void Display(){
		Console.WriteLine("Product: "+productName+" | Category: "+category.GetCategoryName()+" | Price: "+price);
	}
}
