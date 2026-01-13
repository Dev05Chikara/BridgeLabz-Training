//Concatenate Strings Efficiently
using System;
using System.Text;

class ConcatenateStrings{
	static void Main(){
		string[] arr= {"Hello"," ","World"," ","CSharp"};
		StringBuilder sb= new StringBuilder();
		
		foreach(string s in arr){
			sb.Append(s);
		}
		
		Console.WriteLine(sb.ToString());
	}
}
