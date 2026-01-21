using System;
using System.Collections.Generic;

class BinaryQueue{
	static void Main(){
		int n=5;
		Queue<string> q= new Queue<string>();
		q.Enqueue("1");
		for(int i=0;i<n;i++){
			string s= q.Dequeue();
			Console.WriteLine(s);
			q.Enqueue(s+"0");
			q.Enqueue(s+"1");
		}
	}
}
