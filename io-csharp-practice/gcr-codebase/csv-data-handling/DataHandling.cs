using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Web.Script.Serialization;

class DataHandling
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- CSV PRACTICE MENU ---");
            Console.WriteLine("1. Read CSV");
            Console.WriteLine("2. Write CSV");
            Console.WriteLine("3. Count Rows");
            Console.WriteLine("4. Filter Marks > 80");
            Console.WriteLine("5. Search Employee");
            Console.WriteLine("6. Update IT Salary");
            Console.WriteLine("7. Sort Top 5 Salaries");
            Console.WriteLine("8. Validate Email & Phone");
            Console.WriteLine("9. CSV to Objects");
            Console.WriteLine("10. Merge CSV");
            Console.WriteLine("11. Read Large File");
            Console.WriteLine("12. Detect Duplicates");
            Console.WriteLine("13. JSON ↔ CSV");
            Console.WriteLine("14. Encrypt / Decrypt CSV");
            Console.WriteLine("15. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ReadCSV();
                    break;
                case 2:
                    WriteCSV();
                    break;
                case 3:
                    CountRows();
                    break;
                case 4:
                    FilterMarks();
                    break;
                case 5:
                    SearchEmployee();
                    break;
                case 6:
                    UpdateSalary();
                    break;
                case 7:
                    SortSalary();
                    break;
                case 8:
                    ValidateCSV();
                    break;
                case 9:
                    CSVtoObjects();
                    break;
                case 10:
                    MergeCSV();
                    break;
                case 11:
                    ReadLargeFile();
                    break;
                case 12:
                    DetectDuplicates();
                    break;
                case 13:
                    JsonCsvConvert();
                    break;
                case 14:
                    EncryptDecrypt();
                        break;
                case 15:
                    return;
            }
        }
    }

    // Question by question codes...

    // Basics...
    static void ReadCSV()
    {
        Console.Write("Enter CSV file path: ");
        foreach (string line in File.ReadLines(Console.ReadLine()))
            Console.WriteLine(line);
    }

    static void WriteCSV()
    {
        Console.Write("Enter CSV file name: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine("ID,Name,Department,Salary");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("ID: ");
                string id = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Dept: ");
                string dept = Console.ReadLine();
                Console.Write("Salary: ");
                string sal = Console.ReadLine();

                sw.WriteLine(id + "," + name + "," + dept + "," + sal);
            }
        }
    }

    static void CountRows()
    {
        Console.Write("Enter CSV path: ");
        int count = File.ReadLines(Console.ReadLine()).Skip(1).Count();
        Console.WriteLine("Total Records: " + count);
    }

    // Intermediate...
    static void FilterMarks()
    {
        Console.Write("Enter student CSV: ");
        foreach (string l in File.ReadLines(Console.ReadLine()).Skip(1))
        {
            string[] d = l.Split(',');
            if (int.Parse(d[3]) > 80)
                Console.WriteLine(l);
        }
    }

    static void SearchEmployee()
    {
        Console.Write("Enter CSV: ");
        string file = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        foreach (string l in File.ReadLines(file).Skip(1))
        {
            string[] d = l.Split(',');
            if (d[1].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Dept: " + d[2] + " Salary: " + d[3]);
                return;
            }
        }
        Console.WriteLine("Not Found");
    }

    static void UpdateSalary()
    {
        Console.Write("Enter CSV: ");
        string input = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter("updated.csv"))
        {
            sw.WriteLine("ID,Name,Dept,Salary");

            foreach (string l in File.ReadLines(input).Skip(1))
            {
                string[] d = l.Split(',');
                double sal = double.Parse(d[3]);

                if (d[2] == "IT")
                    sal += sal * 0.1;

                sw.WriteLine(d[0] + "," + d[1] + "," + d[2] + "," + sal);
            }
        }
    }

    static void SortSalary()
    {
        Console.Write("Enter CSV: ");
        var list = File.ReadLines(Console.ReadLine()).Skip(1)
            .Select(l => l.Split(','))
            .OrderByDescending(d => double.Parse(d[3]))
            .Take(5);

        foreach (var e in list)
            Console.WriteLine(string.Join(",", e));
    }

    // Advanced...
    static void ValidateCSV()
    {
        Console.Write("Enter CSV: ");
        Regex email = new Regex(@"^\S+@\S+\.\S+$");

        foreach (string l in File.ReadLines(Console.ReadLine()).Skip(1))
        {
            string[] d = l.Split(',');
            if (!email.IsMatch(d[2]) || d[3].Length != 10)
                Console.WriteLine("Invalid: " + l);
        }
    }

    static void CSVtoObjects()
    {
        Console.Write("Enter CSV: ");
        List<Student> list = new List<Student>();

        foreach (string l in File.ReadLines(Console.ReadLine()).Skip(1))
        {
            string[] d = l.Split(',');
            list.Add(new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2])
            });
        }

        foreach (Student s in list)
            Console.WriteLine(s);
    }

    static void MergeCSV()
    {
        Console.Write("CSV1: ");
        var a = File.ReadLines(Console.ReadLine()).Skip(1).ToList();

        Console.Write("CSV2: ");
        var b = File.ReadLines(Console.ReadLine()).Skip(1).ToList();

        using (StreamWriter sw = new StreamWriter("merged.csv"))
        {
            sw.WriteLine("ID,Name,Age,Marks,Grade");

            foreach (string x in a)
            {
                string[] d1 = x.Split(',');
                string match = b.FirstOrDefault(y => y.StartsWith(d1[0] + ","));
                if (match != null)
                {
                    string[] d2 = match.Split(',');
                    sw.WriteLine(d1[0] + "," + d1[1] + "," + d1[2] + "," + d2[1] + "," + d2[2]);
                }
            }
        }
    }

    static void ReadLargeFile()
    {
        Console.Write("Enter large CSV: ");
        int count = 0;
        int chunk = 0;

        foreach (string line in File.ReadLines(Console.ReadLine()))
        {
            chunk++;
            count++;

            if (chunk == 100)
            {
                Console.WriteLine("Processed: " + count);
                chunk = 0;
            }
        }
    }

    static void DetectDuplicates()
    {
        Console.Write("CSV Path: ");
        HashSet<string> seen = new HashSet<string>();

        foreach (string l in File.ReadLines(Console.ReadLine()).Skip(1))
        {
            string id = l.Split(',')[0];
            if (!seen.Add(id))
                Console.WriteLine("Duplicate: " + l);
        }
    }

    static void JsonCsvConvert()
    {
        Console.Write("JSON file: ");
        string json = File.ReadAllText(Console.ReadLine());

        JavaScriptSerializer js = new JavaScriptSerializer();
        List<Student> students = js.Deserialize<List<Student>>(json);

        using (StreamWriter sw = new StreamWriter("students.csv"))
        {
            sw.WriteLine("Id,Name,Age");
            foreach (Student s in students)
                sw.WriteLine(s.Id + "," + s.Name + "," + s.Age);
        }
    }

    static void EncryptDecrypt()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        string encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        string decrypted = Encoding.UTF8.GetString(Convert.FromBase64String(encrypted));

        Console.WriteLine("Encrypted: " + encrypted);
        Console.WriteLine("Decrypted: " + decrypted);
    }
}

// Support class for returning ids and all...
class Student
{
    public int Id;
    public string Name;
    public int Age;

    public override string ToString()
    {
        return Id + " " + Name + " " + Age;
    }
}
