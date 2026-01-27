using System;
using System.Text.RegularExpressions;

class ExtractCurrencyValues
{
    static void Main(string[] args)
    {
        // take user input
        Console.WriteLine("Enter text containing currency values:");
        string input = Console.ReadLine();
        string[] currencies = ExtractCurrencies(input);
        Console.WriteLine("Currency values found:");
        foreach (string currency in currencies)
        {
            Console.WriteLine(currency);
        }
    }

    static string[] ExtractCurrencies(string text)
    {
        // Regular expression to match currency values (e.g., $100, €200, £300)
        string pattern = @"\b(\$|₹)\d+(\.\d{2})?\b";

        MatchCollection matches = Regex.Matches(text, pattern);
        string[] result = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }
        return result;
    }
}