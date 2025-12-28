using System;
class ToggleCase{
	static void Toggle(string s){
		string result= "";
		for(int i=0; i<s.Length; i++){
			if(s[i]>='a' && s[i]<='z') result+= (char)(s[i]-32);
			else if(s[i]>='A' && s[i]<='Z') result+= (char)(s[i]+32);
			else result+= s[i];
		}
		Console.WriteLine("Toggled String: "+result);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Toggle(s);
	}
}
