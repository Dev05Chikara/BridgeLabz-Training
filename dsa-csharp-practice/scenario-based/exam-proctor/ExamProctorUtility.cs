using System;
class ExamProctorUtility{
	private NavigationStack navigation= new NavigationStack();
	private AnswerMap answers= new AnswerMap();
	
	private int[] correctAnswers= {1, 2, 3, 4, 1};
	
	public void VisitQuestion(int questionId){
		navigation.Push(questionId);
		Console.WriteLine("Visited Question "+questionId);
	}
	
	public void AnswerQuestion(int questionId, string answer){
		answers.Put(questionId, answer);
		Console.WriteLine("Answer saved.");
	}
	
	public void GoBack(){
		int q= navigation.Pop();
		if(q!=-1){
			Console.WriteLine("Moved back from Question "+q);
		}
	}
	
	public void SubmitExam(){
		int score= CalculateScore();
		Console.WriteLine("\nExam Submitted.");
		Console.WriteLine("Final Score: "+score);
	}
	
	private int CalculateScore(){
		int score= 0;
		for(int i=1;i<=correctAnswers.Length;i++){
			string ans= answers.Get(i);
			if(ans!=null && ans.Equals(correctAnswers[i-1].ToString())){
				score++;
			}
		}
		return score;
	}
}
