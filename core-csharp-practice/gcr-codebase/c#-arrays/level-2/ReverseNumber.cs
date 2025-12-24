using System;
class ReverseNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= Convert.ToInt32(Console.ReadLine());
        int Temp= Number;
        int Count= 0;
        while(Temp != 0){
            Count++;
            Temp= Temp / 10;
        }
        int[] Digits= new int[Count];
        int Index= 0;
        while(Number != 0){
            Digits[Index]= Number % 10;
            Number= Number / 10;
            Index++;
        }
        Console.Write("Reversed number: ");
        for(int i=0; i<Digits.Length; i++) Console.Write(Digits[i]);
    }
}
