using System;
using System.Reflection;

class Student{
    public string name= "Dev";
}

class DynamicObject{
    static void Main(){
        Type t= typeof(Student);
        object obj= Activator.CreateInstance(t);

        Console.WriteLine(((Student)obj).name);
    }
}
