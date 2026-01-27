using System;
using System.Collections;

class WarningSuppress{
    static void Main(){
        #pragma warning disable
        ArrayList list= new ArrayList();
        list.Add(10);
        list.Add("Dev");
        #pragma warning restore

        foreach(object o in list){
            Console.WriteLine(o);
        }
    }
}
