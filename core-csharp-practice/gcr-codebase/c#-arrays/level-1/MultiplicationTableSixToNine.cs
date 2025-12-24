using System;
class MultiplicationTableSixToNine{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= int.Parse(Console.ReadLine());
        int[] MultiplicationResult= new int[4];
        int Index= 0;
        for(int i=6; i<=9; i++){
            MultiplicationResult[Index]= Number*i;
            Index++;
        }
        Index= 0;
        for(int i=6; i<=9; i++)
        {
            Console.WriteLine(Number+" * "+i+" = "+MultiplicationResult[Index]);
            Index++;
        }
    }
}
