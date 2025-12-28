using System;
class PalindromeChecker{
	static bool IsPalindrome(string s){
		s = s.ToLower();
		int i = 0, j = s.Length - 1;
		while(i < j){
			if(s[i] != s[j]) return false;
			i++;
			j--;
		}
		return true;
	}
	static void Main(){
		Console.Write("Enter String: ");
		string s = Console.ReadLine();
		if(IsPalindrome(s)) Console.WriteLine("Palindrome");
		else Console.WriteLine("Not Palindrome");
	}
}
