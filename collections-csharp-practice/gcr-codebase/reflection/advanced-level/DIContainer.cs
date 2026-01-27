using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute{}

class Service{
    public void Execute(){
        Console.WriteLine("Service Executed");
    }
}

class Client{
    [Inject]
    public Service service;
}

class DIContainer{
    static void Main(){
        Client c= new Client();
        Type t= typeof(Client);

        foreach(FieldInfo f in t.GetFields()){
            if(Attribute.IsDefined(f, typeof(InjectAttribute))){
                object obj= Activator.CreateInstance(f.FieldType);
                f.SetValue(c,obj);
            }
        }
        c.service.Execute();
    }
}
