using System;
using System.Reflection;

class Calculator{
    private int Multiply(int a,int b){
        return a*b;
    }
}

class InvokePrivateMethod{
    static void Main(){
        Calculator c= new Calculator();
        Type t= typeof(Calculator);

        MethodInfo m= t.GetMethod("Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        object result= m.Invoke(c, new object[]{5,4});
        Console.WriteLine("Result: "+result);
    }
}
