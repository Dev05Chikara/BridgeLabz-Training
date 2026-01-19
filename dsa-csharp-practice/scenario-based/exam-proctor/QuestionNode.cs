using System;
class QuestionNode{
	internal int questionId;
	internal string answer;
	public QuestionNode next;
	
	public QuestionNode(int questionId, string answer){
		this.questionId= questionId;
		this.answer= answer;
		next= null;
	}
}
