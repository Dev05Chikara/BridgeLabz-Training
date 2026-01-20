using System;
class ResumeMain{
	static void Main(){
		
		Resume<JobRole> resumeSystem= new Resume<JobRole>();
		
		resumeSystem.AddCandidate(new SoftwareEngineer());
		resumeSystem.AddCandidate(new DataScientist());
		
		ResumeUtility.Screen(resumeSystem);
	}
}
