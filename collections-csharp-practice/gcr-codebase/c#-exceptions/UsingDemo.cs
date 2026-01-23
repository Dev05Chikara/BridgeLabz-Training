using System;
using System.IO;

class UsingDemo
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("info.txt"))
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
