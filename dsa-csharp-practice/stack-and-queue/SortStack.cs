using System;
using System.Collections.Generic;

class SortStack{
	
	static void InsertSorted(Stack<int> st, int value){
		if(st.Count==0 || st.Peek()<=value){
			st.Push(value);
			return;
		}
		
		int temp= st.Pop();
		InsertSorted(st, value);
		st.Push(temp);
	}
	
	static void Sort(Stack<int> st){
		if(st.Count==0){
			return;
		}
		
		int temp= st.Pop();
		Sort(st);
		InsertSorted(st, temp);
	}
	
	static void Main(){
		Stack<int> st= new Stack<int>();
		
		st.Push(30);
		st.Push(10);
		st.Push(20);
		
		Sort(st);
		
		while(st.Count>0){
			Console.WriteLine(st.Pop());
		}
	}
}
