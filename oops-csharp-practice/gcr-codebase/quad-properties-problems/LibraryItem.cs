using System;
using System.Collections.Generic;

interface IReservable{
	void ReserveItem();
	bool CheckAvailability();
}

abstract class LibraryItem{
	private int itemId;
	private string title;

	public LibraryItem(int id, string title){
		this.itemId= id;
		this.title= title;
	}

	public abstract int GetLoanDuration();

	public void GetItemDetails(){
		Console.WriteLine("\nID: "+itemId);
		Console.WriteLine("Title: "+title);
	}
}

class Book : LibraryItem{
	public Book(int id, string title)
		: base(id, title){}

	public override int GetLoanDuration(){
		return 14;
	}
}

class Program{
	static void Main(){
		List<LibraryItem> items= new List<LibraryItem>();
		items.Add(new Book(1, "C# OOPS"));

		foreach(LibraryItem item in items){
			item.GetItemDetails();
			Console.WriteLine("Loan Days: "+item.GetLoanDuration());
		}
	}
}
