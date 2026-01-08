using System;

class MovieManagementSystem{
	public string Title;
	public string Director;
	public int Year;
	public double Rating;
	public MovieManagementSystem next;
	public MovieManagementSystem prev;
	
	static MovieManagementSystem head= null;
	static MovieManagementSystem tail= null;
	
	public static void AddMovieManagementSystem(){
		MovieManagementSystem m= new MovieManagementSystem();
		
		Console.Write("Enter Title: ");
		m.Title= Console.ReadLine();
		
		Console.Write("Enter Director: ");
		m.Director= Console.ReadLine();
		
		Console.Write("Enter Year: ");
		m.Year= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Rating: ");
		m.Rating= Convert.ToDouble(Console.ReadLine());
		
		if(head== null){
			head= tail= m;
		}else{
			tail.next= m;
			m.prev= tail;
			tail= m;
		}
		Console.WriteLine("MovieManagementSystem added.\n");
	}
	
	public static void RemoveMovieManagementSystem(){
		Console.Write("Enter MovieManagementSystem Title: ");
		string title= Console.ReadLine();
		
		MovieManagementSystem temp= head;
		while(temp!= null){
			if(temp.Title== title){
				if(temp== head) head= temp.next;
				if(temp== tail) tail= temp.prev;
				if(temp.prev!= null) temp.prev.next= temp.next;
				if(temp.next!= null) temp.next.prev= temp.prev;
				Console.WriteLine("MovieManagementSystem removed.\n");
				return;
			}
			temp= temp.next;
		}
		Console.WriteLine("MovieManagementSystem not found!");
	}
	
	public static void DisplayForward(){
		MovieManagementSystem temp= head;
		while(temp!= null){
			Display(temp);
			temp= temp.next;
		}
	}
	
	public static void DisplayReverse(){
		MovieManagementSystem temp= tail;
		while(temp!= null){
			Display(temp);
			temp= temp.prev;
		}
	}
	
	public static void Display(MovieManagementSystem m){
		Console.WriteLine("MovieManagementSystem Details:");
		Console.WriteLine("- Title    : "+m.Title);
		Console.WriteLine("- Director : "+m.Director);
		Console.WriteLine("- Year     : "+m.Year);
		Console.WriteLine("- Rating   : "+m.Rating);
		Console.WriteLine("--------------------\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---MovieManagementSystem MENU---");
			Console.WriteLine("1. Add MovieManagementSystem");
			Console.WriteLine("2. Remove MovieManagementSystem");
			Console.WriteLine("3. Display Forward");
			Console.WriteLine("4. Display Reverse");
			Console.WriteLine("5. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: MovieManagementSystem.AddMovieManagementSystem(); break;
				case 2: MovieManagementSystem.RemoveMovieManagementSystem(); break;
				case 3: MovieManagementSystem.DisplayForward(); break;
				case 4: MovieManagementSystem.DisplayReverse(); break;
				case 5: menu= false; break;
				default: Console.WriteLine("Invalid choice!"); break;
			}
		}while(menu== true);
	}
}
