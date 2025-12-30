using System;
class EduQuiz{
	static void DefineQuiz(){
		string[] correctAnswers={
			"A","C","B","D","A","B","C","D","A","C"
		};
		int totalQuestions=correctAnswers.Length;
		string[] studentAnswers=new string[totalQuestions];
		Console.WriteLine("Enter your answers (A/B/C/D):");
		for(int i=0;i<totalQuestions;i++){
			Console.Write("Question "+(i+1)+": ");
			studentAnswers[i]=Console.ReadLine();
		}
		int score=CalculateScore(correctAnswers,studentAnswers);
		ShowResult(correctAnswers,studentAnswers,score);
	}

	static int CalculateScore(string[] correct,string[] student){
		int score=0;
		for(int i=0;i<correct.Length;i++){
			if(student[i].Equals(correct[i],StringComparison.OrdinalIgnoreCase)){
				score++;
			}
		}
		return score;
	}

	static void ShowResult(string[] correct,string[] student,int score){
		Console.WriteLine("\nQuiz Feedback...");
		for(int i=0;i<correct.Length;i++){
			if(student[i].Equals(correct[i],StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine("Question "+(i+1)+": Correct");
			}else{
				Console.WriteLine("Question "+(i+1)+": Incorrect");
			}
		}
		double percentage=(score*100.0)/correct.Length;
		Console.WriteLine("\nTotal Score: "+score+"/"+correct.Length);
		Console.WriteLine("Percentage: "+percentage+"%");
		if(percentage>=40){
			Console.WriteLine("Result: PASS");
		}else{
			Console.WriteLine("Result: FAIL");
		}
	}

	static void Main(){
		DefineQuiz();
	}
}