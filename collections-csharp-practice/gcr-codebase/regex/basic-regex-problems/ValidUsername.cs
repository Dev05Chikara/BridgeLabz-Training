using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;

public class ValidUsername
{
    public static void Main(String[] args)
    {
        // take user Input
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine();
        Console.WriteLine(IsValidUsername(username));
    }

    public static bool IsValidUsername(string userName)
    {
        // regex pattern to check if username is valid
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(userName, pattern);
    }
    }
