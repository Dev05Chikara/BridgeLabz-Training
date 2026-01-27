using System;
using System.Text.RegularExpressions;

class ValidateaSocialSecurityNumber
{
    static void Main(string[] args)
    {
        // test input
        Console.WriteLine("Enter social security number (format: XXX-XX-XXXX):");
        string input = Console.ReadLine();
        if (IsValidSSN(input))
        {
            Console.WriteLine("Valid social security number.");
        }
        else
        {
            Console.WriteLine("Invalid social security number.");
        }
    }

    static bool IsValidSSN(string ssn)
    {
        // Regular expression to match valid social security numbers
        string pattern = @"^(?!000|666|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$";

        // Use Regex to check if the SSN matches the pattern
        return Regex.IsMatch(ssn, pattern);
    }
}