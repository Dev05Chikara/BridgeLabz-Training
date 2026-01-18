using System;
class FitnessTrackerMain{
	static void Main(){
		FitnessTrackerUtility tracker= new FitnessTrackerUtility();
		while(true){
			Console.WriteLine("\n1. Add User Steps");
			Console.WriteLine("2. Update User Steps");
			Console.WriteLine("3. View Leaderboard");
			Console.WriteLine("0. Exit");
			
			Console.Write("Enter choice: ");
			int choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.Write("Enter user name: ");
					string name= Console.ReadLine();
					Console.Write("Enter steps: ");
					int steps= Convert.ToInt32(Console.ReadLine());
					tracker.AddUser(name, steps);
					break;
					
				case 2:
					Console.Write("Enter user name: ");
					name= Console.ReadLine();
					Console.Write("Enter updated steps: ");
					steps= Convert.ToInt32(Console.ReadLine());
					tracker.UpdateUserSteps(name, steps);
					break;
					
				case 3:
					tracker.DisplayLeaderboard();
					break;
					
				case 0:
                Console.WriteLine("Exiting...");
					return;
					
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}
	}
}
