using System;
class VowelsAndConsonants{
	static void Count(string s){
		s= s.ToLower();
		int Vowels= 0;
		int Consonants= 0;
		for(int i=0; i<s.Length; i++){
			if(s[i] >= 'a' && s[i] <= 'z'){
				if(s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u') Vowels++;
				else Consonants++;
			}
		}
		Console.WriteLine("Vowels: "+Vowels+", Consonants: "+Consonants);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Count(s);
	}
}