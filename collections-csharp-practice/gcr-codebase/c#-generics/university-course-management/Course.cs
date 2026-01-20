using System;
using System.Collections.Generic;
class Course<T> where T : CourseType{
	List<T> courses= new List<T>();
	
	public void AddCourse(T course){
		courses.Add(course);
		Console.WriteLine(course.courseName+" added successfully.");
	}
	
	public void DisplayCourses(){
		if(courses.Count==0){
			Console.WriteLine("No courses available.");
			return;
		}
		
		Console.WriteLine("\n--- Course List ---");
		foreach(T course in courses){
			Console.WriteLine(course.GetDetails());
		}
		Console.WriteLine("-------------------");
	}
}
