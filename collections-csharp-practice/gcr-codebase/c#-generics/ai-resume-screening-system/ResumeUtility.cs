using System;
class ResumeUtility{
	public static void Screen<T>(Resume<T> resume)
		where T : JobRole{
		
		Console.WriteLine("AI Screening Started...\n");
		resume.ProcessResumes();
	}
}
