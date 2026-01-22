using System;
using System.IO;

class ImageCopy
{
    static void Main()
    {
        byte[] imageBytes = File.ReadAllBytes("img.jpg");

        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            File.WriteAllBytes("copy.jpg", ms.ToArray());
        }

        Console.WriteLine("Image copied");
    }
}
