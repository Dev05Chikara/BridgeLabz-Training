using System;
using System.Text.RegularExpressions;


class CensorBadWords
{
    static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();
        string censoredText = CensorBadWordsInText(inputText);
        Console.WriteLine("Censored Text:");
        Console.WriteLine(censoredText);

    }

    static string CensorBadWordsInText(string text)
    {

        // bad words list
        string[] badWords = { "damn", "stupid", "bad" };
        // regex pattern to match bad words
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b"; 
        // replace bad words with ****
        string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        return result;
    }
}