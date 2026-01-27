using System;
using System.Diagnostics;
using System.Reflection;

class Task{
    public void Run(){
        for(int i=0;i<1000000;i++){}
    }
}

class MethodTimer{
    static void Main(){
        Task t= new Task();
        MethodInfo m= typeof(Task).GetMethod("Run");

        Stopwatch sw= new Stopwatch();
        sw.Start();
        m.Invoke(t,null);
        sw.Stop();

        Console.WriteLine("Execution Time: "+sw.ElapsedMilliseconds+" ms");
    }
}
