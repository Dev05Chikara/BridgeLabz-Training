using System;
using System.IO;

class CaseConverter
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("input.txt"))
        using (StreamWriter sw = new StreamWriter("lower.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                sw.WriteLine(line.ToLower());
        }
    }
}
