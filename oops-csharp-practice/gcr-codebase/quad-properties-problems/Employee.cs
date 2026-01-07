using System;
using System.Collections.Generic;

interface IDepartment{
	void AssignDepartment(string dept);
	string GetDepartmentDetails();
}

abstract class Employee{
	private int employeeId;
	private string name;
	protected double baseSalary;

	public Employee(int id, string name, double salary){
		this.employeeId= id;
		this.name= name;
		this.baseSalary= salary;
	}

	public abstract double CalculateSalary();

	public void DisplayDetails(){
		Console.WriteLine("\nID: "+employeeId);
		Console.WriteLine("Name: "+name);
		Console.WriteLine("Salary: "+CalculateSalary());
	}
}

class FullTimeEmployee : Employee, IDepartment{
	private string department;

	public FullTimeEmployee(int id, string name, double salary)
		: base(id, name, salary){}

	public override double CalculateSalary(){
		return baseSalary;
	}

	public void AssignDepartment(string dept){
		department= dept;
	}

	public string GetDepartmentDetails(){
		return department;
	}
}

class PartTimeEmployee : Employee{
	private int hours;

	public PartTimeEmployee(int id, string name, double rate, int hours)
		: base(id, name, rate){
		this.hours= hours;
	}

	public override double CalculateSalary(){
		return baseSalary * hours;
	}
}

class Program{
	static void Main(){
		List<Employee> employees= new List<Employee>();

		FullTimeEmployee emp1= new FullTimeEmployee(101, "Dev", 40000);
		emp1.AssignDepartment("IT");

		PartTimeEmployee emp2= new PartTimeEmployee(102, "Abhi", 500, 40);

		employees.Add(emp1);
		employees.Add(emp2);

		foreach(Employee emp in employees){
			emp.DisplayDetails();
		}
	}
}
