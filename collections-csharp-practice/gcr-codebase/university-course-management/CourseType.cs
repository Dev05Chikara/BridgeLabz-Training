abstract class CourseType{
	internal string courseName;
	protected int credits;
	
	public CourseType(string courseName, int credits){
		this.courseName= courseName;
		this.credits= credits;
	}
	
	public abstract string GetEvaluationType();
	
	public string GetDetails(){
		return "Course: "+courseName+" | Credits: "+credits+
		       " | Evaluation: "+GetEvaluationType();
	}
}
