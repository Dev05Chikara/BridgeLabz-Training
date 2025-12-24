using System;
class MultiplicationTable{
    static void Main(){
        Console.WriteLine("Enter a number:");
        int Number= int.Parse(Console.ReadLine());
        int[] MultiplicationTable= new int[10];
        for (int i=1; i<=10; i++) MultiplicationTable[i - 1]= Number*i;
        for (int i=1; i<=10; i++) Console.WriteLine(Number+" * "+i+" = "+MultiplicationTable[i - 1]);
    }
}
