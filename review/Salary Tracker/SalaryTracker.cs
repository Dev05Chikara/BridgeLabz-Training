/*
	Employee salary tracker
	Admin finds salary(highest and lowest) with number of days
	User: 5names
	chirag.patil@bridgelabz.com
*/

using System;
class SalaryTracker{
	static Random R= new Random();
	
	static void Admin(string[] names, int [] attendances, int []salary){
		Console.Write("Please Enter Employee's name: ");
		string searchedName= Console.ReadLine();
		int count=0;
		for(int i=0; i<names.Length; i++){
			if(names[i]==searchedName){
				Console.WriteLine("\nHere are the details of the Employees-");
				Console.WriteLine("Name: "+names[i]);
				Console.WriteLine("Attendances: "+attendances[i]);
				Console.WriteLine("Salary: "+salary[i]);
				count++;
				Console.WriteLine("\nWanna see other?(y/n): ");
				string again= Console.ReadLine();
			    if(again.Equals("y") || again.Equals("Y")) Admin(names, attendances, salary);
			}
		}
		if(count==0){
			Console.WriteLine("Invalid name!");
			Console.Write("Try again? (y/n): ");
			string again= Console.ReadLine();
			if(again.Equals("y") || again.Equals("Y")) Admin(names, attendances, salary);
		}
	}
	
	static void User(string[] names, int [] attendances, int []salary){
		Console.Write("Please Enter your name: ");
		string userName= Console.ReadLine();
		int count=0;
		for(int i=0; i<names.Length; i++){
			if(names[i]==userName){
				Console.WriteLine("\nGot your details-");
				Console.WriteLine("Name: "+names[i]);
				Console.WriteLine("Attendances: "+attendances[i]);
				Console.WriteLine("Salary: "+salary[i]);
				count++;
			}
		}
		if(count==0){
			Console.WriteLine("Invalid name!");
			Console.Write("Try again? (y/n): ");
			string again= Console.ReadLine();
			if(again.Equals("y") || again.Equals("Y")) User(names, attendances, salary);
		}
	}
	
	static void Main(){
		Console.WriteLine("Hey there! How many names you want to enter? ");
		int totalEmployees= int.Parse(Console.ReadLine());
		
		string[] names=new string[totalEmployees];
		Console.WriteLine("Please enter the names-");
		for(int i=0; i<names.Length; i++){
			names[i]=Console.ReadLine();
		}
		
		int [] attendances= new int[totalEmployees];
		for(int i=0; i<attendances.Length; i++) attendances[i]= R.Next(23, 31);
		
		int []salary= new int[totalEmployees];
		//Let's take 200/day
		for(int i=0; i<salary.Length; i++){
			salary[i]= attendances[i]*200;
		}
		
		Console.Write("For Admin(Enter 0) and for User(Enter 1): ");
		int input= int.Parse(Console.ReadLine());
		if(input==0) Admin(names, attendances, salary);
		else if(input==1) User(names, attendances, salary);
		else Console.WriteLine("Invalid entry!");
	}
}