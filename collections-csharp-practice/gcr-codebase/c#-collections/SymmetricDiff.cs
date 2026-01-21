using System;
using System.Collections.Generic;

class SymmetricDiff{
	static void Main(){
		HashSet<int> a= new HashSet<int>(){1,2,3};
		HashSet<int> b= new HashSet<int>(){3,4,5};
		a.SymmetricExceptWith(b);		
		foreach(int x in a) Console.Write(x+" ");
	}
}
