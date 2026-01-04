using System;
class Student{
	public static string UniversityName= "GLA University";
	private static int totalStudents= 0;
	
	public readonly int RollNumber;
	private string Name;
	private char Grade;
	
	public Student(int RollNumber, string Name, char Grade){
		this.RollNumber= RollNumber;
		this.Name= Name;
		this.Grade= Grade;
		totalStudents++;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nStudent Details:");
		Console.WriteLine("University: "+UniversityName);
		Console.WriteLine("Roll No: "+RollNumber);
		Console.WriteLine("Name: "+Name);
		Console.WriteLine("Grade: "+Grade);
	}
	
	public static void DisplayTotalStudents(){
		Console.WriteLine("\nTotal Students: "+totalStudents);
	}
}
class Program{
	static void Main(){
		object stu= new Student(21, "Dev Chikara", 'A');
		
		if(stu is Student){
			((Student)stu).DisplayDetails();
		}
		
		Student.DisplayTotalStudents();
	}
}
