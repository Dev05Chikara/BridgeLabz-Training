//string vs StringBuilder
using System;
using System.Diagnostics;
using System.Text;

class StringPerformance{
	static void Main(){
		int n= 100000;
		Stopwatch sw= new Stopwatch();
		
		sw.Start();
		string s= "";
		for(int i=0;i<n;i++){
			s+= "A";
		}
		sw.Stop();
		Console.WriteLine("String Time: "+sw.ElapsedMilliseconds);
		
		sw.Restart();
		StringBuilder sb= new StringBuilder(n);
		for(int i=0;i<n;i++){
			sb.Append("A");
		}
		sw.Stop();
		Console.WriteLine("StringBuilder Time: "+sw.ElapsedMilliseconds);
	}
}
