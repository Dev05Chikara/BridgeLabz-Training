using System;
class LongestWord{
	static void Find(string s){
		string word= "";
		string longest= "";
		for(int i=0; i<=s.Length; i++){
			if(i<s.Length && s[i]!=' ') word+= s[i];
			else{
				if(word.Length>longest.Length) longest= word;
				word= "";
			}
		}
		Console.WriteLine("Longest Word: "+longest);
	}
	static void Main(){
		Console.Write("Enter the Sentence: ");
		string s= Console.ReadLine();
		Find(s);
	}
}
