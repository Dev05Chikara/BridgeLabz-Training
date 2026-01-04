using System;
class Book{
	public static string LibraryName= "Central Library";
	
	public readonly string ISBN;
	private string Title;
	private string Author;
	
	public Book(string Title, string Author, string ISBN){
		this.Title= Title;
		this.Author= Author;
		this.ISBN= ISBN;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nBook Details:");
		Console.WriteLine("Library: "+LibraryName);
		Console.WriteLine("Title: "+Title);
		Console.WriteLine("Author: "+Author);
		Console.WriteLine("ISBN: "+ISBN);
	}
	
	public static void DisplayLibraryName(){
		Console.WriteLine("\nLibrary Name: "+LibraryName);
	}
}
class Program{
	static void Main(){
		object book= new Book("C# Basics", "MS", "ISBN001");
		
		if(book is Book){
			((Book)book).DisplayDetails();
		}
		
		Book.DisplayLibraryName();
	}
}
