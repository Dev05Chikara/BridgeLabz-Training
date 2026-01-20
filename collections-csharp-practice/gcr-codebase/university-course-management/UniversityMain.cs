using System;
class UniversityMain{
	static void Main(){
		Course<ExamCourse> examCourses= new Course<ExamCourse>();
		examCourses.AddCourse(new ExamCourse("Data Structures", 4));
		examCourses.AddCourse(new ExamCourse("Operating Systems", 3));
		examCourses.DisplayCourses();
		
		Course<AssignmentCourse> assignmentCourses= new Course<AssignmentCourse>();
		assignmentCourses.AddCourse(new AssignmentCourse("AI Project", 5));
		assignmentCourses.AddCourse(new AssignmentCourse("Web Development", 4));
		assignmentCourses.DisplayCourses();
	}
}
