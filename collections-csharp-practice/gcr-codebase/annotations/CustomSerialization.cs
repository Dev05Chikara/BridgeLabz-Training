using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute{
    public string Name;
    public JsonFieldAttribute(string name){
        Name= name;
    }
}

class User{
    [JsonField("user_name")]
    public string name= "Dev";

    [JsonField("user_age")]
    public int age= 22;
}

class JsonSerializer{
    static void Main(){
        User u= new User();
        Type t= typeof(User);

        Console.Write("{ ");
        FieldInfo[] fields= t.GetFields();

        for(int i=0;i<fields.Length;i++){
            JsonFieldAttribute a=
                (JsonFieldAttribute)Attribute.GetCustomAttribute(
                    fields[i], typeof(JsonFieldAttribute));

            Console.Write("\""+a.Name+"\":\""+
                fields[i].GetValue(u)+"\"");
            if(i<fields.Length-1) Console.Write(", ");
        }
        Console.WriteLine(" }");
    }
}
