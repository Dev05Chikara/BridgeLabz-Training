using System;
using System.Collections.Generic;

class SetOps{
	static void Main(){
		HashSet<int> a= new HashSet<int>(){1,2,3};
		HashSet<int> b= new HashSet<int>(){3,4,5};
		
		HashSet<int> union= new HashSet<int>(a);
		union.UnionWith(b);
		
		HashSet<int> inter= new HashSet<int>(a);
		inter.IntersectWith(b);
		
		Console.WriteLine("Union:");
		foreach(int x in union) Console.Write(x+" ");
		
		Console.WriteLine("\nIntersection:");
		foreach(int x in inter) Console.Write(x+" ");
	}
}
