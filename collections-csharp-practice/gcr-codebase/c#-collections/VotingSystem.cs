using System;
using System.Collections.Generic;

class VotingSystem{
	static void Main(){
		Dictionary<string,int> votes= new Dictionary<string,int>();
		votes["A"] = 2;
		votes["B"] = 5;
		SortedDictionary<string,int> sorted= new SortedDictionary<string,int>(votes);
		
		foreach(var kv in sorted)
			Console.WriteLine(kv.Key+" : "+kv.Value);
	}
}
