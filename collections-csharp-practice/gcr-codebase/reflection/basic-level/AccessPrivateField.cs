using System;
using System.Reflection;

class Person{
    private int age= 20;
}

class AccessPrivateField{
    static void Main(){
        Person p= new Person();
        Type t= typeof(Person);

        FieldInfo f= t.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        f.SetValue(p, 25);
        Console.WriteLine("Age: "+f.GetValue(p));
    }
}
