using System;
class Library{
	static void DefineBooks(){
		int totalBooks=10;
		string[,] books=new string[totalBooks,3];

		books[0,0]="Dune";
		books[0,1]="Frank Herbert";
		books[0,2]="Available";

		books[1,0]="Dune Messiah";
		books[1,1]="Frank Herbert";
		books[1,2]="Checkout";

		books[2,0]="Children of Dune";
		books[2,1]="Frank Herbert";
		books[2,2]="Available";

		books[3,0]="God Emperor of Dune";
		books[3,1]="Frank Herbert";
		books[3,2]="Available";

		books[4,0]="Foundation";
		books[4,1]="Isaac Asimov";
		books[4,2]="Checkout";

		books[5,0]="I, Robot";
		books[5,1]="Isaac Asimov";
		books[5,2]="Available";

		books[6,0]="The War of the Worlds";
		books[6,1]="H. G. Wells";
		books[6,2]="Available";

		books[7,0]="The Time Machine";
		books[7,1]="H. G. Wells";
		books[7,2]="Checkout";

		books[8,0]="Neuromancer";
		books[8,1]="William Gibson";
		books[8,2]="Available";

		books[9,0]="Ender's Game";
		books[9,1]="Orson Scott Card";
		books[9,2]="Checkout";

		Console.WriteLine("Listed Books...");
		for(int i=0;i<totalBooks;i++)
			Console.WriteLine((i+1)+". "+books[i,0]);
		SearchTheBook(books);
	}

	static void SearchTheBook(string[,] books){
		bool wannaSearch=true;
		while(wannaSearch){
			Console.Write("\nSearch your book: ");
			string searchedBook=Console.ReadLine().ToLower();
			int count=0;
			for(int i=0;i<books.GetLength(0);i++){
				if(books[i,0].ToLower().Contains(searchedBook)){
					count++;
				}
			}
			if(count==0){
				Console.Write("Sorry! Book not Found. Search Another? (Enter 0 for No, and 1 for Yes): ");
				int searchAgain=int.Parse(Console.ReadLine());
				if(searchAgain==0){
					Console.WriteLine("Thanks for visiting!");
					return;
				}else continue;
			}else{
				Console.WriteLine("Searched Books...");
				Console.WriteLine("{0,-25} {1,-25} {2,-10}","Title","Author","Status");
				Console.WriteLine(new string('-',65));
				for(int i=0;i<books.GetLength(0);i++){
					if(books[i,0].ToLower().Contains(searchedBook)){
						Console.WriteLine("{0,-25} {1,-25} {2,-10}",books[i,0],books[i,1],books[i,2]);
					}
				}
				wannaSearch=false;
				BorrowTheBook(books);
			}
		}
	}

	static void BorrowTheBook(string[,] books){
		bool borrowBook=false;
		Console.Write("\nWanna borrow a Book? (Enter 0 for No, and 1 for Yes): ");
		int borrow=int.Parse(Console.ReadLine());
		if(borrow==1) borrowBook=true;
		else{
			Console.WriteLine("Thanks for visiting!");
			return;
		}
		while(borrowBook){
			Console.Write("Enter the name of the Book: ");
			string borrowedBook=Console.ReadLine().ToLower();
			bool checkAvailability=false;
			int gotBook=-1;
			for(int i=0;i<books.GetLength(0);i++){
				if((books[i,0].ToLower()).Equals(borrowedBook)){
					if(books[i,2].Equals("Available")){
						checkAvailability=true;
						gotBook=i;
						break;
					}
				}
			}
			if(checkAvailability){
				books[gotBook,2]="Checkout";
				Console.WriteLine("...DONE...");
				Console.WriteLine("Book '"+books[gotBook,0]+"' borrowed to you.");
			}else{
				Console.WriteLine("Sorry! Book not available or already checked out.");
			}
			Console.Write("\nWanna borrow another Book? (Enter 0 for No, and 1 for Yes): ");
			int borrowAnother=int.Parse(Console.ReadLine());
			if(borrowAnother==0){
				borrowBook=false;
				Console.WriteLine("Thanks for visiting!");
			}
		}
	}

	static void Main(){
		DefineBooks();
	}
}
