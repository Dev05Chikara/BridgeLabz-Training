//Read User Input and Write to File
using System;
using System.IO;

class WriteToFile{
	static void Main(){
		Console.Write("Enter text: ");
		string input= Console.ReadLine();
		
		File.WriteAllText("output.txt", input);
	}
}
