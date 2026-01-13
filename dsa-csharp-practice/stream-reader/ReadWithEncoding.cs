//StreamReader with Encoding
using System;
using System.IO;
using System.Text;

class ReadWithEncoding{
	static void Main(){
		using(StreamReader sr= new StreamReader("data.txt", Encoding.UTF8)){
			Console.WriteLine(sr.ReadToEnd());
		}
	}
}
