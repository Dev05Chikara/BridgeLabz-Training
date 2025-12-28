using System;
class ReverseString{
	static void Reverse(string s){
		string rev= "";
		for(int i=s.Length-1; i>=0; i--) rev+= s[i];
		Console.WriteLine("Reversed String: "+rev);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Reverse(s);
	}
}
