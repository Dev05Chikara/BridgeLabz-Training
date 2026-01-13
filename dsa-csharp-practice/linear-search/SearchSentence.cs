//Search Word in Sentences
using System;

class SearchSentence{
	static void Main(){
		string[] sentences= {
			"I love CSharp",
			"Java is powerful",
			"CSharp is awesome"
		};
		
		string key= "CSharp";
		
		foreach(string s in sentences){
			if(s.Contains(key)){
				Console.WriteLine(s);
				break;
			}
		}
	}
}
