using System;
class Book2{
	private string title;
	private string author;
	private int price;
	private bool availability;
	
	public Book2(string title, string author, int price){
		this.title= title;
		this.author= author;
		this.price= price;
		this.availability= true;
	}
	
	public void BorrowBook(){
		if(availability){
			availability= false;
			Console.WriteLine("\nBook borrowed successfully.");
		}
		else{
			Console.WriteLine("\nBook is already issued.");
		}
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nLibrary Book Details:");
		Console.WriteLine("- Title: "+title);
		Console.WriteLine("- Author: "+author);
		Console.WriteLine("- Price: "+price);
		Console.WriteLine("- Available: "+availability);
	}
}
class Program{
	static void Main(){
		Book2 book1= new Book2("Clean Code", "Robert C. Martin", 550);
		
		book1.DisplayDetails();
		book1.BorrowBook();
		book1.DisplayDetails();
	}
}
