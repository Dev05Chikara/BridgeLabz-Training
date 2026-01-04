using System;
class Book{
	public string ISBN;
	protected string title;
	private string author;
	
	public Book(string ISBN, string title, string author){
		this.ISBN= ISBN;
		this.title= title;
		this.author= author;
	}
	
	public void SetAuthor(string author){
		this.author= author;
	}
	
	public void GetAuthor(){
		Console.WriteLine("Author: "+author);
	}
}
class EBook: Book{
	public EBook(string ISBN, string title, string author)
		: base(ISBN, title, author){
	}
	
	public void DisplayBookInfo(){
		Console.WriteLine("ISBN: "+ISBN);
		Console.WriteLine("Title: "+title);
	}
}
class Program{
	static void Main(){
		EBook ebook1= new EBook("ISBN123", "C# Basics", "Unknown");
		ebook1.DisplayBookInfo();
		ebook1.GetAuthor();
	}
}
