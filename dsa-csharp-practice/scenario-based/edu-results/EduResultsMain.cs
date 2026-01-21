using System;
using System.Collections.Generic;

class EduResultsMain{
	static void Main(){
		List<Student> district1= new List<Student>();
		district1.Add(new Student("Aman", 90));
		district1.Add(new Student("Riya", 85));
		
		List<Student> district2= new List<Student>();
		district2.Add(new Student("Neha", 95));
		district2.Add(new Student("Rahul", 88));
		
		List<Student> allStudents= new List<Student>();
		allStudents.AddRange(district1);
		allStudents.AddRange(district2);
		
		List<Student> rankList= MergeSortUtility.MergeSort(allStudents);
		Console.WriteLine("State Rank List:\n");
		int rank=1;
		foreach(Student s in rankList){
			Console.WriteLine(
				"Rank "+rank+" : "+s.Name+" | Marks: "+s.Marks
			);
			rank++;
		}
	}
}
