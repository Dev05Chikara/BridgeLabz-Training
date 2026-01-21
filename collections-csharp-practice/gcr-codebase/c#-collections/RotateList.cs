using System;
using System.Collections.Generic;

class RotateList{
	static void Main(){
		List<int> list= new List<int>(){10,20,30,40,50};
		int k=2;
		List<int> rotated= new List<int>();
		for(int i=k;i<list.Count;i++) rotated.Add(list[i]);
		for(int i=0;i<k;i++) rotated.Add(list[i]);
		foreach(int x in rotated) Console.Write(x+" ");
	}
}
