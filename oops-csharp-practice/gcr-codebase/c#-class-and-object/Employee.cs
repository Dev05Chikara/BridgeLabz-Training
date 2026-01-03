using System;
class Employee{
	private string name;
	private int id;
	private int salary;
	
	public Employee(string name, int id, int salary){
		this.name= name;
		this.id= id;
		this.salary= salary;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nEmployee Details:");
		Console.WriteLine("- Name: "+name);
		Console.WriteLine("- ID: "+id);
		Console.WriteLine("- Salary: "+salary);
	}
}
class Program{
	static void Main(){
		Employee employee1= new Employee("Dev Chikara", 13, 28000);
		Employee employee2= new Employee("Krishna Agrawal", 30, 30000);
		Employee employee3= new Employee("Abhishek Maheshwari", 40, 28000);
		Employee employee4= new Employee("Shivam Gupta", 4, 35000);
		
		employee1.DisplayDetails();
		employee2.DisplayDetails();
		employee3.DisplayDetails();
		employee4.DisplayDetails();
	}
}