using System;
using System.Text.RegularExpressions;

class ExtractWebpages
{
    static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();
        string[] webpages = ExtractWebpageURLs(inputText);
        Console.WriteLine("Extracted Webpage URLs:");
        foreach (string url in webpages)
        {
            Console.WriteLine(url);
        }
    }

    public static string[] ExtractWebpageURLs(string text)
    {
        // regex pattern to extract webpage URLs
        string pattern = @"https?://[^\s]+";
        MatchCollection matches = Regex.Matches(text, pattern);
        string[] webpageURLs = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            webpageURLs[i] = matches[i].Value;
        }
        return webpageURLs;
    }
}