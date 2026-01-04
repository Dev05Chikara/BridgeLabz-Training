using System;
class Employee{
	public int employeeID;
	protected string department;
	private int salary;
	
	public Employee(int employeeID, string department, int salary){
		this.employeeID= employeeID;
		this.department= department;
		this.salary= salary;
	}
	
	public void UpdateSalary(int newSalary){
		this.salary= newSalary;
	}
	
	public void GetSalary(){
		Console.WriteLine("Salary: "+salary);
	}
}
class Manager: Employee{
	public Manager(int employeeID, string department, int salary)
		: base(employeeID, department, salary){
	}
	
	public void DisplayManagerInfo(){
		Console.WriteLine("Employee ID: "+employeeID);
		Console.WriteLine("Department: "+department);
	}
}
class Program{
	static void Main(){
		Manager manager1= new Manager(501, "IT", 80000);
		manager1.DisplayManagerInfo();
		manager1.GetSalary();
	}
}
