using System;
using System.Collections.Generic;

class WordFreq{
	static void Main(){
		string text="Hello world hello C-Sharp";
		string[] words= text.ToLower().Split(' ');
		Dictionary<string,int> map= new Dictionary<string,int>();
		foreach(string w in words){
			if(map.ContainsKey(w)) map[w]++;
			else map[w]=1;
		}
		foreach(var kv in map)
			Console.WriteLine(kv.Key+" : "+kv.Value);
	}
}
