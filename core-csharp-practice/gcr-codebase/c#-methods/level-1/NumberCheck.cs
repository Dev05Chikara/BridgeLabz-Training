using System;
class NumberCheck{
    static int CheckNumber(int Number){
        if(Number > 0) return 1;
        else if(Number < 0) return -1;
        else return 0;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        int Result = CheckNumber(Number);
        Console.WriteLine("Result: "+Result);
    }
}
