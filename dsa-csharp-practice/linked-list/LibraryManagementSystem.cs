using System;

class LibraryManagementSystem{
	public int LibraryManagementSystemId;
	public string Title;
	public string Author;
	public string Genre;
	public bool Available;
	public LibraryManagementSystem next;
	public LibraryManagementSystem prev;
	
	static LibraryManagementSystem head= null;
	static LibraryManagementSystem tail= null;
	
	public static void AddLibraryManagementSystem(){
		LibraryManagementSystem b= new LibraryManagementSystem();
		
		Console.Write("Enter LibraryManagementSystem ID: ");
		b.LibraryManagementSystemId= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Title: ");
		b.Title= Console.ReadLine();
		
		Console.Write("Enter Author: ");
		b.Author= Console.ReadLine();
		
		Console.Write("Enter Genre: ");
		b.Genre= Console.ReadLine();
		
		b.Available= true;
		
		if(head== null){
			head= tail= b;
		}else{
			tail.next= b;
			b.prev= tail;
			tail= b;
		}
		Console.WriteLine("LibraryManagementSystem added.\n");
	}
	
	public static void RemoveLibraryManagementSystem(){
		Console.Write("Enter LibraryManagementSystem ID: ");
		int id= Convert.ToInt32(Console.ReadLine());
		
		LibraryManagementSystem temp= head;
		while(temp!= null){
			if(temp.LibraryManagementSystemId== id){
				if(temp== head) head= temp.next;
				if(temp== tail) tail= temp.prev;
				if(temp.prev!= null) temp.prev.next= temp.next;
				if(temp.next!= null) temp.next.prev= temp.prev;
				Console.WriteLine("LibraryManagementSystem removed.\n");
				return;
			}
			temp= temp.next;
		}
		Console.WriteLine("LibraryManagementSystem not found!");
	}
	
	public static void UpdateStatus(){
		Console.Write("Enter LibraryManagementSystem ID: ");
		int id= Convert.ToInt32(Console.ReadLine());
		
		LibraryManagementSystem temp= head;
		while(temp!= null){
			if(temp.LibraryManagementSystemId== id){
				temp.Available= !temp.Available;
				Console.WriteLine("Status updated.\n");
				return;
			}
			temp= temp.next;
		}
		Console.WriteLine("LibraryManagementSystem not found!");
	}
	
	public static void DisplayForward(){
		LibraryManagementSystem temp= head;
		while(temp!= null){
			Display(temp);
			temp= temp.next;
		}
	}
	
	public static void DisplayReverse(){
		LibraryManagementSystem temp= tail;
		while(temp!= null){
			Display(temp);
			temp= temp.prev;
		}
	}
	
	public static void Display(LibraryManagementSystem b){
		Console.WriteLine("LibraryManagementSystem Details:");
		Console.WriteLine("- ID        : "+b.LibraryManagementSystemId);
		Console.WriteLine("- Title     : "+b.Title);
		Console.WriteLine("- Author    : "+b.Author);
		Console.WriteLine("- Genre     : "+b.Genre);
		Console.WriteLine("- Available : "+b.Available);
		Console.WriteLine("---------------------\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---LIBRARY MENU---");
			Console.WriteLine("1. Add LibraryManagementSystem");
			Console.WriteLine("2. Remove LibraryManagementSystem");
			Console.WriteLine("3. Update Availability");
			Console.WriteLine("4. Display Forward");
			Console.WriteLine("5. Display Reverse");
			Console.WriteLine("6. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: LibraryManagementSystem.AddLibraryManagementSystem(); break;
				case 2: LibraryManagementSystem.RemoveLibraryManagementSystem(); break;
				case 3: LibraryManagementSystem.UpdateStatus(); break;
				case 4: LibraryManagementSystem.DisplayForward(); break;
				case 5: LibraryManagementSystem.DisplayReverse(); break;
				case 6: menu= false; break;
			}
		}while(menu== true);
	}
}
