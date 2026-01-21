using System;
using System.Collections.Generic;

class FrequencyCounter{
	static void Main(){
		string[] items= {"apple","banana","apple","orange"};
		Dictionary<string,int> map= new Dictionary<string,int>();
		foreach(string s in items){
			if(map.ContainsKey(s)) map[s]++;
			else map[s]=1;
		}
		foreach(var kv in map){
			Console.WriteLine(kv.Key+" : "+kv.Value);
		}
	}
}
