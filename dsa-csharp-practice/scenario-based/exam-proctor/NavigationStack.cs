using System;
class NavigationStack{
	private int[] stack= new int[50];
	private int top= -1;
	
	public void Push(int questionId){
		if(top==stack.Length-1){
			Console.WriteLine("Navigation stack overflow.");
			return;
		}
		stack[++top]= questionId;
	}
	
	public int Pop(){
		if(top==-1){
			Console.WriteLine("Navigation stack underflow.");
			return -1;
		}
		return stack[top--];
	}
	
	public int Peek(){
		if(top==-1) return -1;
		return stack[top];
	}
}
