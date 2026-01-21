using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList{
	static void Main(){
		ArrayList arr= new ArrayList(){1,2,3,4,5};
		for(int i=0, j=arr.Count-1;i<j;i++,j--){
			object temp= arr[i];
			arr[i]= arr[j];
			arr[j]= temp;
		}
		Console.WriteLine("Reversed ArrayList:");
		foreach(object o in arr) Console.Write(o+" ");
		
		Console.WriteLine("\n");
		
		LinkedList<int> list= new LinkedList<int>(new int[]{1,2,3,4,5});
		LinkedList<int> rev= new LinkedList<int>();
		
		foreach(int x in list){
			rev.AddFirst(x);
		}
		Console.WriteLine("Reversed LinkedList:");
		foreach(int x in rev) Console.Write(x+" ");
	}
}
