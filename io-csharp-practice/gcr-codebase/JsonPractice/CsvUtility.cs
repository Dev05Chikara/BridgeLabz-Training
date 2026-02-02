using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public static class CsvUtility
{
    public static void CsvToJson()
    {
        string[] csv =
        {
            "Name,Age",
            "Dev,22",
            "Aman,26"
        };

        var list = new List<Student>();

        for (int i = 1; i < csv.Length; i++)
        {
            var data = csv[i].Split(',');
            list.Add(new Student
            {
                Name = data[0],
                Age = int.Parse(data[1])
            });
        }

        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }
}
