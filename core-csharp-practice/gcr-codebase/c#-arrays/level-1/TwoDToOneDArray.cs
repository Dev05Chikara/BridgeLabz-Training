using System;
class TwoDToOneDArray{
    static void Main(){
        Console.Write("Enter number of rows: ");
        int Rows= int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int Columns= int.Parse(Console.ReadLine());
        int[,] Matrix= new int[Rows, Columns];
        Console.WriteLine("Enter matrix elements:");
        for(int i=0; i<Rows; i++) for (int j=0; j<Columns; j++) Matrix[i, j] = int.Parse(Console.ReadLine());
        int[] Array= new int[Rows*Columns];
        int Index= 0;
        for (int i=0; i<Rows; i++){
            for (int j=0; j<Columns; j++){
                Array[Index]= Matrix[i, j];
                Index++;
            }
        }
        Console.WriteLine("1D Array:");
        for (int i=0; i<Array.Length; i++) Console.Write(Array[i]+" ");
    }
}
