using System;
class MostFrequentChar{
	static void Find(string s){
		int max= 0;
		char result= ' ';
		for(int i=0; i<s.Length; i++){
			int count= 0;
			for(int j=0; j<s.Length; j++) if(s[i]==s[j]) count++;
			if(count>max){
				max= count;
				result= s[i];
			}
		}
		Console.WriteLine("Most Frequent Character: "+result);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Find(s);
	}
}
