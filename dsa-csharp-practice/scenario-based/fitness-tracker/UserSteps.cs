using System;
class UserSteps{
	private string userName;
	private int steps;
	
	public UserSteps(string userName, int steps){
		this.userName= userName;
		this.steps= steps;
	}
	
	public string GetUserName(){
		return userName;
	}
	
	public int GetSteps(){
		return steps;
	}
	
	public void UpdateSteps(int newSteps){
		steps= newSteps;
	}
}
