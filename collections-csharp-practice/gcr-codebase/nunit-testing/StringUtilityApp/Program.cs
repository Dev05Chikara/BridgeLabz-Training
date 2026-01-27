using System;

namespace StringUtilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtils utils = new StringUtils();

            Console.WriteLine("Reverse: " + utils.Reverse("hello"));
            Console.WriteLine("Is Palindrome (madam): " + utils.IsPalindrome("madam"));
            Console.WriteLine("Uppercase: " + utils.ToUpperCase("dotnet"));

            Console.ReadLine();
        }
    }
}
