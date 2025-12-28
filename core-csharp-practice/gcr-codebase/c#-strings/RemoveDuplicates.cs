using System;
class RemoveDuplicates{
	static void Remove(string s){
		string result= "";
		for(int i=0; i<s.Length; i++){
			bool found= false;
			for(int j=0; j<result.Length; j++){
				if(s[i]==result[j]){
					found= true;
					break;
				}
			}
			if(!found) result+= s[i];
		}
		Console.WriteLine("Modified String: "+result);
	}
	static void Main(){
		Console.Write("Enter the String: ");
		string s= Console.ReadLine();
		Remove(s);
	}
}
