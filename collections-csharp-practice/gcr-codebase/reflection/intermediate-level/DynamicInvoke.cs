using System;
using System.Reflection;

class MathOperations{
    public int Add(int a,int b){ return a+b; }
    public int Subtract(int a,int b){ return a-b; }
    public int Multiply(int a,int b){ return a*b; }
}

class DynamicInvoke{
    static void Main(){
        MathOperations m= new MathOperations();
        Type t= typeof(MathOperations);

        Console.Write("Enter method name: ");
        string method= Console.ReadLine();

        MethodInfo mi= t.GetMethod(method);
        object result= mi.Invoke(m,new object[]{10,5});

        Console.WriteLine("Result: "+result);
    }
}
