using System;
class PasswordChecker
{
    IPassword password = new PasswordBacktrack();

    public void CheckPassword()
    {
        Console.Write("Enter password to crack: ");
        string yourPassword = Console.ReadLine();
        
        //Start-time...
        DateTime start = DateTime.Now;

        Console.WriteLine("Cracking password...");
        password.PasswordCheck(yourPassword, "", 0);

        //End-time...
        DateTime end= DateTime.Now;
        Console.WriteLine("Time taken: "+(end-start).TotalSeconds+" sec");
    }
}
