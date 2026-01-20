using System;
using System.Collections.Generic;
class Resume<T> where T : JobRole{
	List<T> candidates= new List<T>();
	
	public void AddCandidate(T role){
		candidates.Add(role);
	}
	
	public void ProcessResumes(){
		Console.WriteLine("Processing Resumes...\n");
		
		foreach(T role in candidates){
			Console.WriteLine("Role: "+role.GetRoleName()+" | Score: "+role.Evaluate());
		}
	}
}
