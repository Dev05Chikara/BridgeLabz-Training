using System;
using System.IO;

class FileCopy
{
    static void Main()
    {
        string source = "input.txt";
        string dest = "output.txt";

        try
        {
            if (!File.Exists(source))
            {
                Console.WriteLine("Source file not found");
                return;
            }

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("File copied successfully");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
