//Remove Duplicates Using StringBuilder
using System;
using System.Text;

class RemoveDuplicates{
	static void Main(){
		string input= "programming";
		StringBuilder sb= new StringBuilder();
		
		foreach(char c in input){
			if(sb.ToString().IndexOf(c)==-1){
				sb.Append(c);
			}
		}
		
		Console.WriteLine(sb.ToString());
	}
}
