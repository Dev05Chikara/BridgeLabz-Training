using System;
using System.Collections.Generic;

class QueueUsingStacks{
	private Stack<int> s1= new Stack<int>();
	private Stack<int> s2= new Stack<int>();
	
	public void Enqueue(int data){
		s1.Push(data);
	}
	
	public int Dequeue(){
		if(s1.Count==0 && s2.Count==0){
			Console.WriteLine("Queue is Empty");
			return -1;
		}
		
		if(s2.Count==0){
			while(s1.Count>0){
				s2.Push(s1.Pop());
			}
		}
		
		return s2.Pop();
	}
}

class Program{
	static void Main(){
		QueueUsingStacks q= new QueueUsingStacks();
		
		q.Enqueue(10);
		q.Enqueue(20);
		q.Enqueue(30);
		
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());
	}
}
