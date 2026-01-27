using System;
using System.Text.RegularExpressions;

class ValidateanIPAddress
{
    static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter an IP address:");
        string ipAddress = Console.ReadLine();
        Console.WriteLine(IsValidIPAddress(ipAddress));
    }

    static bool IsValidIPAddress(string ipAddress)
    {
        // regex pattern to check if IP address is valid
        string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        return Regex.IsMatch(ipAddress, pattern);
    }
}