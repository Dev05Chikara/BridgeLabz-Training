using System;
using System.IO;

class FileReadDemo
{
    static void Main()
    {
        try
        {
            string data = File.ReadAllText("data.txt");
            Console.WriteLine(data);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
