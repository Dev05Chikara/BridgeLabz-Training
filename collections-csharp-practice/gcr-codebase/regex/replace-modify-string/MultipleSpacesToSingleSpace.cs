using System;
using System.Text.RegularExpressions;

class MultipleSpacesToSingleSpace
{
    static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a text with multiple spaces:");
        string inputText = Console.ReadLine();
        string modifiedText = ReplaceMultipleSpacesWithSingleSpace(inputText);
        Console.WriteLine("Modified Text:");
        Console.WriteLine(modifiedText);
    }

    public static string ReplaceMultipleSpacesWithSingleSpace(string text)
    {
        // regex pattern to match multiple spaces
        string pattern = @"\s+";
        // replace multiple spaces with a single space
        string result = Regex.Replace(text, pattern, " ");
        return result;
    }
}