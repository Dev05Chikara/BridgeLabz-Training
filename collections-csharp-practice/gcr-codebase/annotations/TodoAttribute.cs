using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method,AllowMultiple=true)]
class TodoAttribute : Attribute{
    public string Task;
    public string AssignedTo;
    public string Priority;

    public TodoAttribute(string task,string assignedTo,string priority="MEDIUM"){
        Task= task;
        AssignedTo= assignedTo;
        Priority= priority;
    }
}

class Project{
    [Todo("Fix login","Dev","HIGH")]
    [Todo("Add logout","Aman")]
    public void Auth(){}
}

class TodoDemo{
    static void Main(){
        MethodInfo m= typeof(Project).GetMethod("Auth");
        object[] todos= m.GetCustomAttributes(typeof(TodoAttribute),false);

        foreach(TodoAttribute t in todos){
            Console.WriteLine(t.Task+" "+t.AssignedTo+" "+t.Priority);
        }
    }
}
