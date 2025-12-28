using System;
class CompareStrings{
	static void Compare(string s1, string s2){
		int i= 0;
		while(i<s1.Length && i<s2.Length){
			if(s1[i]<s2[i]){
				Console.WriteLine(s1+" comes before "+s2);
				return;
			}
			else if(s1[i]>s2[i]){
				Console.WriteLine(s2+" comes before "+s1);
				return;
			}
			i++;
		}
		if(s1.Length==s2.Length) Console.WriteLine("Both Strings are Equal");
		else if(s1.Length<s2.Length) Console.WriteLine(s1+" comes before "+s2);
		else Console.WriteLine(s2+" comes before "+s1);
	}
	static void Main(){
		Console.Write("Enter First String: ");
		string s1= Console.ReadLine();
		Console.Write("Enter Second String: ");
		string s2= Console.ReadLine();
		Compare(s1, s2);
	}
}
