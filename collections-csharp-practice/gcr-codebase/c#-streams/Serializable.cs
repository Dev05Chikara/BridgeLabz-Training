using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

[Serializable]
class Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class EmployeeStore
{
    static void Main()
    {
        List<Employee> list = new List<Employee>
        {
            new Employee{ Id=1, Name="Dev", Department="IT", Salary=50000 }
        };

        DataContractJsonSerializer ser =
            new DataContractJsonSerializer(typeof(List<Employee>));

        using (FileStream fs = new FileStream("emp.json", FileMode.Create))
            ser.WriteObject(fs, list);

        using (FileStream fs = new FileStream("emp.json", FileMode.Open))
        {
            var result = (List<Employee>)ser.ReadObject(fs);
            foreach (var e in result)
                Console.WriteLine(e.Name + " " + e.Salary);
        }
    }
}
