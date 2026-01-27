using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method,AllowMultiple=true)]
class BugReportAttribute : Attribute{
    public string Description;
    public BugReportAttribute(string desc){
        Description= desc;
    }
}

class App{
    [BugReport("UI Bug")]
    [BugReport("Crash on load")]
    public void Run(){}
}

class BugDemo{
    static void Main(){
        MethodInfo m= typeof(App).GetMethod("Run");
        object[] bugs= m.GetCustomAttributes(typeof(BugReportAttribute),false);

        foreach(BugReportAttribute b in bugs){
            Console.WriteLine(b.Description);
        }
    }
}
