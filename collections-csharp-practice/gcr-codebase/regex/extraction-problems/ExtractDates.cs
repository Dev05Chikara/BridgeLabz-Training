using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    public static void Main(string[] args)
    {
        // take user input 
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();
        string[] dates = ExtractDatesFromText(inputText);
        Console.WriteLine("Extracted Dates:");
        foreach (string date in dates)
        {
            Console.WriteLine(date);
        }
    }

    public static string[] ExtractDatesFromText(string text)
    {
        // regex pattern to extract dates in DD/MM/YYYY format
        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/(19|20)\d\d\b"; 
        MatchCollection matches = Regex.Matches(text, pattern);
        string[] dates = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            dates[i] = matches[i].Value;
        }
        return dates;
    }
}