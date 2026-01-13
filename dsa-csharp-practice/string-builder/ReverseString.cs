//Reverse a String Using StringBuilder
using System;
using System.Text;

class ReverseString{
	static void Main(){
		string input= "hello";
		StringBuilder sb= new StringBuilder(input);
		
		for(int i=0;i<sb.Length/2;i++){
			char temp= sb[i];
			sb[i]= sb[sb.Length-1-i];
			sb[sb.Length-1-i]= temp;
		}
		
		Console.WriteLine(sb.ToString());
	}
}
