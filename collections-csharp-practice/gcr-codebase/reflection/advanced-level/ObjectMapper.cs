using System;
using System.Collections.Generic;
using System.Reflection;

class User{
    public string name;
    public int age;
}

class ObjectMapper{
    static T ToObject<T>(Dictionary<string,object> map){
        T obj= Activator.CreateInstance<T>();
        Type t= typeof(T);

        foreach(string key in map.Keys){
            FieldInfo f= t.GetField(key);
            if(f!=null){
                f.SetValue(obj,map[key]);
            }
        }
        return obj;
    }

    static void Main(){
        Dictionary<string,object> data= new Dictionary<string,object>();
        data["name"]= "Dev";
        data["age"]= 22;

        User u= ToObject<User>(data);
        Console.WriteLine(u.name+" "+u.age);
    }
}
