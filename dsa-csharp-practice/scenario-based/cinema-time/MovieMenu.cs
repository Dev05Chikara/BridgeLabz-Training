using System;

class MovieMenu{
	public static void Start(){
		ICinema cinema= new MovieUtility();
		int choice;
		
		do{
			Console.WriteLine("\n===== CINEMA MENU =====");
			Console.WriteLine("1. Add Movie");
			Console.WriteLine("2. Search Movie");
			Console.WriteLine("3. Display All Movies");
			Console.WriteLine("4. Exit");
			Console.Write("Enter your choice: ");
			
			choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					cinema.AddMovie();
					break;
					
				case 2:
					cinema.SearchMovie();
					break;
					
				case 3:
					cinema.DisplayAllMovies();
					break;
					
				case 4:
					Console.WriteLine("Thank You! Exiting...");
					break;
					
				default:
					Console.WriteLine("Invalid Choice!");
					break;
			}
			
		}while(choice!=4);
	}
}
