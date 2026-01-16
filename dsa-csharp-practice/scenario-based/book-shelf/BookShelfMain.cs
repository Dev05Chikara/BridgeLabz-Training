using System;
class BookShelfMain
{
    static void Main()
    {
        LibrarySystem library= new LibrarySystem();
        int choice;
        Console.WriteLine("-------Welcome to Library Book-Shelf-------");
        do
        {
            Console.WriteLine("\n1. Add Genre");
			Console.WriteLine("2. Add Book");
			Console.WriteLine("3. Remove Book");
			Console.WriteLine("0. Exit");
            Console.WriteLine("--------------");
            Console.Write("Enter choice: ");
            choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
					Console.Write("Enter genre name: ");
					library.AddGenre(Console.ReadLine());
					break;
					
				case 2:
					Console.Write("Genre: ");
					string genre= Console.ReadLine();
					Console.Write("Book Name: ");
					string bookName= Console.ReadLine();
					Console.Write("Author: ");
					string author= Console.ReadLine();
					library.AddBook(genre, bookName, author);
					break;
					
				case 3:
					Console.Write("Genre: ");
					genre= Console.ReadLine();
					Console.Write("Book Name: ");
					bookName= Console.ReadLine();
					Console.Write("Author: ");
					author= Console.ReadLine();
					library.RemoveBook(genre, bookName, author);
					break;
				
				case 0:
                    Console.WriteLine("--- Exiting ---");
					break;
					
				default:
					Console.WriteLine("--- Invalid choice ---");
					break;

            }
        }while(choice != 0);
    }
}