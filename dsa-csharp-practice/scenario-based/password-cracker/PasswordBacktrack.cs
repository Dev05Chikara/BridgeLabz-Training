using System;
public class PasswordBacktrack : IPassword
{
    // private bool isCracked = false;
    public void PasswordCheck(string password, string result, int idx)
    {
        // if(isCracked) return;
        if (idx == password.Length)
        {
            // Console.WriteLine("Trying password: " + result);
            if (result.Equals(password))
            {
                Console.WriteLine("\nPassword Cracked: " + result);
                Console.WriteLine("----------------------");
                // isCracked= true;
            }
            return;
        }

        const string chars= "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        foreach(char ch in chars)
        {
            PasswordCheck(password, result + ch, idx + 1);
        }
    }
}
