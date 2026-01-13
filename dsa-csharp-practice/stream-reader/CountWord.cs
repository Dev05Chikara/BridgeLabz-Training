//Count Word Occurrence in File
using System;
using System.IO;

class CountWord{
	static void Main(){
		string word= "hello";
		int count= 0;
		
		using(StreamReader sr= new StreamReader("data.txt")){
			string line;
			
			while((line= sr.ReadLine())!=null){
				string[] parts= line.Split(' ');
				foreach(string p in parts){
					if(p.Equals(word)){
						count++;
					}
				}
			}
		}
		
		Console.WriteLine(count);
	}
}
