using System;
using System.Text.RegularExpressions;

public class ValidHexColorCode
{
    public static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a hex color code:");
        string hexColorCode = Console.ReadLine();
        Console.WriteLine(IsValidHexColorCode(hexColorCode));
    }

    public static bool IsValidValidHexColorCode(string hexColorCode)
    {
        // regex pattern to check if hex color code is valid
        string pattern = @"^#[a-zA-Z0-9]{6}$";
        return Regex.IsMatch(hexColorCode, pattern);
    }
}
