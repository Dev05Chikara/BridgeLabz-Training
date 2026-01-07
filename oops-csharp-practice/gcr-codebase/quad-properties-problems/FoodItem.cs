using System;
using System.Collections.Generic;

interface IDiscountable{
	double ApplyDiscount();
	string GetDiscountDetails();
}

abstract class FoodItem{
	protected double price;
	protected int quantity;

	public FoodItem(double price, int quantity){
		this.price= price;
		this.quantity= quantity;
	}

	public abstract double CalculateTotalPrice();
}

class VegItem : FoodItem{
	public VegItem(double price, int qty)
		: base(price, qty){}

	public override double CalculateTotalPrice(){
		return price * quantity;
	}
}

class Program{
	static void Main(){
		List<FoodItem> items= new List<FoodItem>();
		items.Add(new VegItem(120, 2));

		foreach(FoodItem f in items){
			Console.WriteLine("Total: "+f.CalculateTotalPrice());
		}
	}
}
