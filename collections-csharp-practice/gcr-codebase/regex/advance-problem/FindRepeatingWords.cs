using System;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
    static void Main(string[] args)
    {
        // take user input
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] repeatingWords = ExtractRepeatingWords(input);
        Console.WriteLine("Repeating words found:");
        foreach (string word in repeatingWords)
        {
            Console.WriteLine(word);
        }
    }

    static string[] ExtractRepeatingWords(string text)
    {
        // Regular expression to match repeating words
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        string[] result = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }
        return result;
    }
}