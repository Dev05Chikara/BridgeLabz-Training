using System;
class Person{
	private string name;
	private int age;
	
	public Person(string name, int age){
		this.name= name;
		this.age= age;
	}
	
	//Cloning
	public Person(Person person){
		this.name= person.name;
		this.age= person.age;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nPerson Details:");
		Console.WriteLine("- Name: "+name);
		Console.WriteLine("- Age: "+age);
	}
}
class Program{
	static void Main(){
		Person person1= new Person("Dev Chikara", 22);
		Person person2= new Person(person1);
		
		person1.DisplayDetails();
		person2.DisplayDetails();
	}
}
