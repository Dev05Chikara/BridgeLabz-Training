using System;
class Book{
	private string title;
	private string author;
	private int price;
	
	public Book(){
		title= "Unknown";
		author= "Unknown";
		price= 0;
	}
	
	public Book(string title, string author, int price){
		this.title= title;
		this.author= author;
		this.price= price;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nBook Details:");
		Console.WriteLine("- Title: "+title);
		Console.WriteLine("- Author: "+author);
		Console.WriteLine("- Price: "+price);
	}
}
class Program{
	static void Main(){
		Book book1= new Book();
		Book book2= new Book("Atomic Habits", "James Clear", 450);
		
		book1.DisplayDetails();
		book2.DisplayDetails();
	}
}
