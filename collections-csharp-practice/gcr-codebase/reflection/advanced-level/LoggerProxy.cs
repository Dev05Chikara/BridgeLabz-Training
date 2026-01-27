using System;
using System.Reflection;

interface IGreeting{
    void SayHello();
}

class Greeting : IGreeting{
    public void SayHello(){
        Console.WriteLine("Hello User!");
    }
}

class LoggerProxy{
    public static void Invoke(object obj,string method){
        MethodInfo m= obj.GetType().GetMethod(method);
        Console.WriteLine("Logging: "+method);
        m.Invoke(obj,null);
    }
}

class ProxyDemo{
    static void Main(){
        Greeting g= new Greeting();
        LoggerProxy.Invoke(g,"SayHello");
    }
}
