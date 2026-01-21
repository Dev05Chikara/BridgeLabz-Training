using System;
using System.Collections.Generic;

class InvertMap{
	static void Main(){
		Dictionary<string,int> map= new Dictionary<string,int>();
		map["A"]=1; map["B"]=2; map["C"]=1;
		Dictionary<int,List<string>> inv= new Dictionary<int,List<string>>();
		foreach(var kv in map){
			if(!inv.ContainsKey(kv.Value))
				inv[kv.Value]= new List<string>();
			
			inv[kv.Value].Add(kv.Key);
		}
		foreach(var kv in inv){
			Console.Write(kv.Key+" = ");
			foreach(string s in kv.Value) Console.Write(s+" ");
			Console.WriteLine();
		}
	}
}
