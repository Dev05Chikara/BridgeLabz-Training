using System;
class AnagramCheck{
	static void Check(string s1, string s2){
		if(s1.Length!=s2.Length){
			Console.WriteLine("Not Anagrams");
			return;
		}
		int count= 0;
		for(int i=0; i<s1.Length; i++){
			for(int j=0; j<s2.Length; j++){
				if(s1[i]==s2[j]){
					count++;
					break;
				}
			}
		}
		if(count==s1.Length) Console.WriteLine("Anagrams");
		else Console.WriteLine("Not Anagrams");
	}
	static void Main(){
		Console.Write("Enter First String: ");
		string s1= Console.ReadLine();
		Console.Write("Enter Second String: ");
		string s2= Console.ReadLine();
		Check(s1, s2);
	}
}
