using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute{
    public string Level;
    public ImportantMethodAttribute(string level="HIGH"){
        Level= level;
    }
}

class Service{
    [ImportantMethod]
    public void Start(){}

    [ImportantMethod("LOW")]
    public void Stop(){}
}

class ImportantDemo{
    static void Main(){
        MethodInfo[] methods= typeof(Service).GetMethods();

        foreach(MethodInfo m in methods){
            object attr= Attribute.GetCustomAttribute(
                m, typeof(ImportantMethodAttribute));

            if(attr!=null){
                Console.WriteLine(m.Name);
            }
        }
    }
}
