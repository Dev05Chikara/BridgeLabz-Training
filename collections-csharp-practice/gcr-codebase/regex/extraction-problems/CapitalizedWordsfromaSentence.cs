using System;
using System.Text.RegularExpressions;

class CapitalizedWordsfromaSentence
{
    public static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a sentence:");
        string inputText = Console.ReadLine();
        string[] capitalizedWords = ExtractCapitalizedWords(inputText);
        Console.WriteLine("Extracted Capitalized Words:");
        foreach (string word in capitalizedWords)
        {
            Console.WriteLine(word);
        }
    }

    public static string[] ExtractCapitalizedWords(string text)
    {
        // regex pattern to extract capitalized words
        string pattern = @"\b[A-Z][a-zA-Z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        string[] capitalizedWords = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            capitalizedWords[i] = matches[i].Value;
        }
        return capitalizedWords;
    }
}