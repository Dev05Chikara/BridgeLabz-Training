using System;
class SubstringCount{
	static void Count(string s, string sub){
		int count= 0;
		for(int i=0; i<=s.Length-sub.Length; i++){
			bool match= true;
			for(int j=0; j<sub.Length; j++){
				if(s[i+j]!=sub[j]){
					match= false;
					break;
				}
			}
			if(match) count++;
		}
		Console.WriteLine("Occurrences: "+count);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Console.Write("Enter the Substring: ");
		string sub= Console.ReadLine();
		Count(s, sub);
	}
}
