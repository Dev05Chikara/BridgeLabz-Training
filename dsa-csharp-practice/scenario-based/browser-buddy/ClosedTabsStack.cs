using System;
class ClosedTabsStack{
	private BrowserTab[] stack= new BrowserTab[10];
	private int top= -1;
	
	public void Push(BrowserTab tab){
		if(top==stack.Length-1){
			Console.WriteLine("Closed tab stack full.");
			return;
		}
		stack[++top]= tab;
	}
	
	public BrowserTab Pop(){
		if(top==-1){
			Console.WriteLine("No closed tabs to restore.");
			return null;
		}
		return stack[top--];
	}
}
