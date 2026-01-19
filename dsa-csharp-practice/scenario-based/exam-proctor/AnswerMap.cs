using System;
class AnswerMap{
	private QuestionNode[] table= new QuestionNode[10];
	
	private int Hash(int key){
		return key % table.Length;
	}
	
	public void Put(int questionId, string answer){
		int index= Hash(questionId);
		QuestionNode head= table[index];
		
		QuestionNode temp= head;
		while(temp!=null){
			if(temp.questionId==questionId){
				temp.answer= answer;
				return;
			}
			temp= temp.next;
		}
		QuestionNode newNode= new QuestionNode(questionId, answer);
		newNode.next= head;
		table[index]= newNode;
	}
	
	public string Get(int questionId){
		int index= Hash(questionId);
		QuestionNode temp= table[index];
		
		while(temp!=null){
			if(temp.questionId==questionId){
				return temp.answer;
			}
			temp= temp.next;
		}
		return null;
	}
}
