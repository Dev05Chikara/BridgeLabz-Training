using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

public static class JsonUtility
{
    public static void CreateStudentJson()
    {
        var student = new Student
        {
            Name = "Dev",
            Age = 22,
            Subjects = new List<string> { "AI", "ML", "DSA" }
        };

        Console.WriteLine(JsonConvert.SerializeObject(student, Formatting.Indented));
    }

    public static void ConvertCarToJson()
    {
        var car = new Car { Brand = "BMW", Model = "X5" };
        Console.WriteLine(JsonConvert.SerializeObject(car, Formatting.Indented));
    }

    public static void ExtractFields()
    {
        string json = @"{ 'name':'Dev','email':'dev@gmail.com','age':25 }";
        dynamic obj = JsonConvert.DeserializeObject(json);
        Console.WriteLine($"{obj.name} | {obj.email}");
    }

    public static void MergeJson()
    {
        JObject a = JObject.Parse(@"{'A':1}");
        JObject b = JObject.Parse(@"{'B':2}");
        a.Merge(b);
        Console.WriteLine(a);
    }

    public static void ValidateJsonSchema()
    {
        string schemaJson = @"{
          'type':'object',
          'properties':{
            'email':{'type':'string','format':'email'}
          }
        }";

        string data = @"{ 'email':'test@gmail.com' }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(data);

        Console.WriteLine(obj.IsValid(schema)
            ? "Valid JSON"
            : "Invalid JSON");
    }

    public static void ListToJsonArray()
    {
        var cars = new List<Car>
        {
            new Car{Brand="Audi",Model="A6"},
            new Car{Brand="Tesla",Model="Model 3"}
        };

        Console.WriteLine(JsonConvert.SerializeObject(cars, Formatting.Indented));
    }

    public static void FilterAge()
    {
        var users = new List<User>
        {
            new User{Name="A",Age=20},
            new User{Name="B",Age=30}
        };

        var filtered = users.Where(u => u.Age > 25);
        foreach (var u in filtered)
            Console.WriteLine(u.Name);
    }

    public static void JsonToXml()
    {
        string json = @"{ 'name':'Dev','age':22 }";
        var xml = JsonConvert.DeserializeXNode(json, "Root");
        Console.WriteLine(xml);
    }
}
