using System;
class PalindromeCheck{
	static void Check(string s){
		string rev= "";
		for(int i=s.Length-1; i>=0; i--) rev+= s[i];
		if(s==rev) Console.WriteLine("Palindrome String");
		else Console.WriteLine("Not a Palindrome");
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Check(s);
	}
}
