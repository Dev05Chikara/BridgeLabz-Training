using System;
using System.Text.RegularExpressions;

public class ExtractAllEmailAddressesfromaText
{
    public static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();
        string[] emailAddresses = ExtractEmailAddresses(inputText);
        Console.WriteLine("Extracted Email Addresses:");
        foreach (string email in emailAddresses)
        {
            Console.WriteLine(email);
        }
    }

    public static string[] ExtractEmailAddresses(string text)
    {
        // regex pattern to extract email addresses
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);
        string[] emailAddresses = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            emailAddresses[i] = matches[i].Value;
        }   
        return emailAddresses;
    }
}