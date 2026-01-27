using System;
using System.Reflection;

class Employee{
    public int id=1;
    public string name="Dev";
}

class JsonGenerator{
    static void Main(){
        Employee e= new Employee();
        Type t= typeof(Employee);

        Console.Write("{ ");
        FieldInfo[] fields= t.GetFields();

        for(int i=0;i<fields.Length;i++){
            Console.Write("\""+fields[i].Name+"\":\""+
                fields[i].GetValue(e)+"\"");
            if(i<fields.Length-1) Console.Write(", ");
        }
        Console.WriteLine(" }");
    }
}
