using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (string word in File.ReadAllText("text.txt")
                 .ToLower().Split(' '))
        {
            if (!map.ContainsKey(word))
                map[word] = 0;
            map[word]++;
        }

        foreach (var w in map.OrderByDescending(x => x.Value).Take(5))
            Console.WriteLine(w.Key + " : " + w.Value);
    }
}
