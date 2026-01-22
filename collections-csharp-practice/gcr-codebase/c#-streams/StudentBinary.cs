using System;
using System.IO;

class StudentBinary
{
    static void Main()
    {
        using (BinaryWriter bw = new BinaryWriter(File.Open("stud.dat", FileMode.Create)))
        {
            bw.Write(101);
            bw.Write("Dev");
            bw.Write(8.9);
        }

        using (BinaryReader br = new BinaryReader(File.Open("stud.dat", FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
