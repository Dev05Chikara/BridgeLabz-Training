using System;
using System.IO;
using System.Diagnostics;

class BufferedCopy
{
    static void Main()
    {
        string src = "bigfile.dat";
        string dest = "copy.dat";

        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(src, FileMode.Open))
        using (FileStream fsWrite = new FileStream(dest, FileMode.Create))
        using (BufferedStream br = new BufferedStream(fsRead))
        using (BufferedStream bw = new BufferedStream(fsWrite))
        {
            byte[] buffer = new byte[4096];
            int bytes;

            while ((bytes = br.Read(buffer, 0, buffer.Length)) > 0)
                bw.Write(buffer, 0, bytes);
        }

        sw.Stop();
        Console.WriteLine("Buffered Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
