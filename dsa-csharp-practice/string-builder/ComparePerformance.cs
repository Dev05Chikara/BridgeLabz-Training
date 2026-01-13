//Compare StringBuilder Performance
using System;
using System.Text;
using System.Diagnostics;

class ComparePerformance{
	static void Main(){
		int n= 10000;
		
		Stopwatch sw= new Stopwatch();
		sw.Start();
		
		StringBuilder sb= new StringBuilder();
		for(int i=0;i<n;i++){
			sb.Append("A");
		}
		
		sw.Stop();
		Console.WriteLine("StringBuilder Time: "+sw.ElapsedMilliseconds);
	}
}
