using System;
using System.Reflection;

class Configuration{
    private static string API_KEY= "OLD_KEY";
}

class ModifyStatic{
    static void Main(){
        Type t= typeof(Configuration);

        FieldInfo f= t.GetField("API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static);

        f.SetValue(null,"NEW_SECRET_KEY");
        Console.WriteLine("Updated API Key: "+f.GetValue(null));
    }
}
