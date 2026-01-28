using System;
using System.Diagnostics;

class LibraryMenu{
	public static void Start(){
		ILibrary library= new LibraryUtility();
		int choice;
		Console.WriteLine("---------Welcome to Library-----------");
		
		do{
			Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Search a book");
            Console.WriteLine("3. Checkout a book");
            Console.WriteLine("4. Display all books");
            Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");
			choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					library.AddBook();
					break;
					
				case 2:
					library.SearchBook();
					break;
					
				case 3:
					library.CheckoutBook();
					break;
					
				case 4:
					library.DisplayBooks();
					break;

                case 5:
                    Console.WriteLine("Thanks for visiting!");
					Console.WriteLine("--------------------------------------");
                    break;
					
				default:
					Console.WriteLine("Invalid Choice!");
					break;
			}
			
		}while(choice!=5);
	}
}
