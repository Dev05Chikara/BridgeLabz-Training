using System;
using System.Text.RegularExpressions;

class ProgrammingLanguageNames
{
    static void Main(string[] args)
    {
        // take user input
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] languages = ExtractProgrammingLanguages(input);
        Console.WriteLine("Programming languages found:");
        foreach (string lang in languages)
        {
            Console.WriteLine(lang);
        }

    }

    static string[] ExtractProgrammingLanguages(string text)
    {
        // Regular expression to match programming language names
        string pattern = @"\b(C#|Java|Python|JavaScript)\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        string[] result = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }
        return result;
    }
    
}