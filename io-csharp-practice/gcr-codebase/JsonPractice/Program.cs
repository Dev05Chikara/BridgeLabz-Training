using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------------------------\n");
        Console.WriteLine("...BASIC JSON Questions...");
        JsonUtility.CreateStudentJson();
        JsonUtility.ConvertCarToJson();
        JsonUtility.ExtractFields();
        JsonUtility.MergeJson();
        JsonUtility.ValidateJsonSchema();
        JsonUtility.ListToJsonArray();
        JsonUtility.FilterAge();

        Console.WriteLine("\n-------------------------\n");
        Console.WriteLine("...HANDS ON Questions...");
        JsonUtility.JsonToXml();
        CsvUtility.CsvToJson();

        Console.WriteLine("\n-------------------------\n");
    }
}
