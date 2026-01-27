using System;
using System.Text.RegularExpressions;

class CreditCardNumber
{
    static void Main(string[] args)
    {
        // test input
        Console.WriteLine("Enter credit card number:");
        string input = Console.ReadLine();
        if (IsValidCreditCardNumber(input))
        {
            Console.WriteLine("Valid credit card number.");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }

    static bool IsValidCreditCardNumber(string cardNumber)
    {
        // Regular expression to match valid credit card numbers
        string pattern = @"^(?:4[0-9]{12}(?:[0-9]{3})?          # Visa
                           |  5[1-5][0-9]{14}                  # MasterCard
                          )$";

        // Remove spaces and hyphens from the input
        cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

        // Use Regex to check if the card number matches the pattern
        return Regex.IsMatch(cardNumber, pattern, RegexOptions.IgnorePatternWhitespace);
    }
}