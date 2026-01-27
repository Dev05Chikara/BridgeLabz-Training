using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute{
    public string Priority;
    public string AssignedTo;

    public TaskInfoAttribute(string priority,string assignedTo){
        Priority= priority;
        AssignedTo= assignedTo;
    }
}

class TaskManager{
    [TaskInfo("HIGH","Dev")]
    public void CompleteTask(){}
}

class TaskInfoDemo{
    static void Main(){
        MethodInfo m= typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute t=
            (TaskInfoAttribute)Attribute.GetCustomAttribute(
                m, typeof(TaskInfoAttribute));

        Console.WriteLine(t.Priority+" "+t.AssignedTo);
    }
}
