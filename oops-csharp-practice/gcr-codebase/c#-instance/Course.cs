using System;
class Course{
	private string courseName;
	private int duration;
	private int fee;
	public static string instituteName= "BridgeLabz";
	
	public Course(string courseName, int duration, int fee){
		this.courseName= courseName;
		this.duration= duration;
		this.fee= fee;
	}
	
	public void DisplayCourseDetails(){
		Console.WriteLine("\nCourse Details:");
		Console.WriteLine("- Course: "+courseName);
		Console.WriteLine("- Duration: "+duration+" months");
		Console.WriteLine("- Fee: "+fee);
		Console.WriteLine("- Institute: "+instituteName);
	}
	
	public static void UpdateInstituteName(string newName){
		instituteName= newName;
	}
}
class Program{
	static void Main(){
		Course c1= new Course("C# .NET", 4, 45000);
		Course c2= new Course("Java", 6, 50000);
		
		c1.DisplayCourseDetails();
		Course.UpdateInstituteName("BridgeLabz Solutions");
		c2.DisplayCourseDetails();
	}
}
