using System;
using System.IO;

class ErrorFinder
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("log.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                if (line.ToLower().Contains("error"))
                    Console.WriteLine(line);
        }
    }
}
