using System;
class Employee{
	public static string CompanyName= "BridgeLabz";
	private static int totalEmployees= 0;
	
	public readonly int Id;
	private string Name;
	private string Designation;
	
	public Employee(int Id, string Name, string Designation){
		this.Id= Id;
		this.Name= Name;
		this.Designation= Designation;
		totalEmployees++;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nEmployee Details:");
		Console.WriteLine("Company: "+CompanyName);
		Console.WriteLine("ID: "+Id);
		Console.WriteLine("Name: "+Name);
		Console.WriteLine("Designation: "+Designation);
	}
	
	public static void DisplayTotalEmployees(){
		Console.WriteLine("\nTotal Employees: "+totalEmployees);
	}
}
class Program{
	static void Main(){
		object emp= new Employee(13, "Dev Chikara", "Intern");
		
		if(emp is Employee){
			((Employee)emp).DisplayDetails();
		}
		
		Employee.DisplayTotalEmployees();
	}
}
