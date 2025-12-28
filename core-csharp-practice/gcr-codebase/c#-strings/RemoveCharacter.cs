using System;
class RemoveCharacter{
	static void Remove(string s, char ch){
		string result= "";
		for(int i=0; i<s.Length; i++) if(s[i]!=ch) result+= s[i];
		Console.WriteLine("Modified String: "+result);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Console.Write("Enter Character to Remove: ");
		char ch= Console.ReadLine()[0];
		Remove(s, ch);
	}
}
