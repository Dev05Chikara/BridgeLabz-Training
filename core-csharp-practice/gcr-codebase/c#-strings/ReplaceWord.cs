using System;
class ReplaceWord{
	static void Replace(string s, string oldWord, string newWord){
		string result= "";
		string word= "";
		for(int i=0; i<=s.Length; i++){
			if(i<s.Length && s[i]!=' ') word+= s[i];
			else{
				if(word==oldWord) result+= newWord+" ";
				else result+= word+" ";
				word= "";
			}
		}
		Console.WriteLine("Modified Sentence: "+result.Trim());
	}
	static void Main(){
		Console.Write("Enter the Sentence: ");
		string s= Console.ReadLine();
		Console.Write("Enter Word to Replace: ");
		string oldWord= Console.ReadLine();
		Console.Write("Enter New Word: ");
		string newWord= Console.ReadLine();
		Replace(s, oldWord, newWord);
	}
}
