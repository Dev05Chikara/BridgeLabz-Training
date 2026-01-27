using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute{}

class Worker{
    [LogExecutionTime]
    public void Work(){
        for(int i=0;i<1000000;i++){}
    }
}

class ExecutionLogger{
    static void Main(){
        Worker w= new Worker();
        MethodInfo m= typeof(Worker).GetMethod("Work");

        Stopwatch sw= new Stopwatch();
        sw.Start();
        m.Invoke(w,null);
        sw.Stop();

        Console.WriteLine("Time: "+sw.ElapsedMilliseconds+" ms");
    }
}
