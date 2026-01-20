class AssignmentCourse : CourseType{
	public AssignmentCourse(string courseName, int credits)
		: base(courseName, credits){}
	
	public override string GetEvaluationType(){
		return "Assignments + Projects";
	}
}
