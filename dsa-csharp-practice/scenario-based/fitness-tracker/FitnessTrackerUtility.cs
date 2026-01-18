using System;
class FitnessTrackerUtility{
	private UserSteps[] users= new UserSteps[20];
	private int totalUsers= 0;
	
	public void AddUser(string name, int steps){
		if(totalUsers==users.Length){
			Console.WriteLine("User limit reached.");
			return;
		}
		users[totalUsers++]= new UserSteps(name, steps);
		SortBySteps();
		Console.WriteLine("User added and leaderboard updated.");
	}
	
	public void UpdateUserSteps(string name, int steps){
		for(int i=0;i<totalUsers;i++){
			if(users[i].GetUserName().Equals(name)){
				users[i].UpdateSteps(steps);
				SortBySteps();
				Console.WriteLine("Steps updated and leaderboard refreshed.");
				return;
			}
		}
		Console.WriteLine("User not found.");
	}
	
	private void SortBySteps(){
		for(int i=0;i<totalUsers-1;i++){
			for(int j=0;j<totalUsers-i-1;j++){
				if(users[j].GetSteps()<users[j+1].GetSteps()){
					UserSteps temp= users[j];
					users[j]= users[j+1];
					users[j+1]= temp;
				}
			}
		}
	}
	
	public void DisplayLeaderboard(){
		if(totalUsers==0){
			Console.WriteLine("No users available.");
			return;
		}
		Console.WriteLine("\n--- Daily Step Leaderboard ---");
		for(int i=0;i<totalUsers;i++){
			Console.WriteLine((i+1)+". "+users[i].GetUserName()+" - "+users[i].GetSteps()+" steps");
		}
	}
}
