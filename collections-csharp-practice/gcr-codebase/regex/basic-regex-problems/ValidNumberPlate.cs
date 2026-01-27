using System;
using System.Text.RegularExpressions;

public class ValidNumberaPlate
{
    public static void Main(string[] args)
    {
        // take user Input
        Console.WriteLine("Enter a vehicle number plate:");
        string numberPlate = Console.ReadLine();
        Console.WriteLine(IsValidNumberPlate(numberPlate));
    }

    public static bool IsValidNumberPlate(string numberPlate)
    {
        // regex pattern to check the number platre is valid
        string pattern = @"^[A-Z]{2}[0-9]{4}";
        return Regex.IsMatch(numberPlate, pattern);
    }
}