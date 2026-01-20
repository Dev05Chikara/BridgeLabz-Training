class ExamCourse : CourseType{
	public ExamCourse(string courseName, int credits)
		: base(courseName, credits){}
	
	public override string GetEvaluationType(){
		return "Written Exam";
	}
}
