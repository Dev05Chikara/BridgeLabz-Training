using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("user.txt"))
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                string age = Console.ReadLine();

                Console.Write("Language: ");
                string lang = Console.ReadLine();

                writer.WriteLine(name);
                writer.WriteLine(age);
                writer.WriteLine(lang);
            }

            Console.WriteLine("Data saved");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
