using System;
class Student{
	public int rollNumber;
	protected string name;
	private double CGPA;
	
	public Student(int rollNumber, string name, double CGPA){
		this.rollNumber= rollNumber;
		this.name= name;
		this.CGPA= CGPA;
	}
	
	public void SetCGPA(double cgpa){
		this.CGPA= cgpa;
	}
	
	public void GetCGPA(){
		Console.WriteLine("CGPA: "+CGPA);
	}
}
class PostgraduateStudent: Student{
	public PostgraduateStudent(int rollNumber, string name, double CGPA)
		: base(rollNumber, name, CGPA){
	}
	
	public void DisplayName(){
		Console.WriteLine("Student Name: "+name);
	}
}
class Program{
	static void Main(){
		PostgraduateStudent s1= new PostgraduateStudent(101, "Dev Chikara", 8.5);
		s1.DisplayName();
		s1.GetCGPA();
	}
}
