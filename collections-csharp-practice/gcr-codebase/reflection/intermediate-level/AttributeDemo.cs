using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute{
    public string Name;
    public AuthorAttribute(string name){
        Name= name;
    }
}

[Author("Dev Chikara")]
class Book{}

class AttributeDemo{
    static void Main(){
        Type t= typeof(Book);
        AuthorAttribute a= (AuthorAttribute)
            Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

        Console.WriteLine("Author: "+a.Name);
    }
}
