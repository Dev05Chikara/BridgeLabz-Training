using System;
class Product{
	private string productName;
	private int discount;
	
	public Product(string productName, int discount){
		this.productName= productName;
		this.discount= discount;
	}
	
	public string GetProductName(){
		return productName;
	}
	
	public int GetDiscount(){
		return discount;
	}
}
