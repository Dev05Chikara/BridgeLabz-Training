using System;
class LargestAndSecondLargestDigitUsingArray{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= Convert.ToInt32(Console.ReadLine());
        int MaxDigit= 10;
        int[] Digits= new int[MaxDigit];
        int Index= 0;
        while (Number != 0){
            if (Index == MaxDigit){
                MaxDigit += 10;
                int[] Temp= new int[MaxDigit];
                for(int i=0; i<Digits.Length; i++) Temp[i]= Digits[i];
                Digits= Temp;
            }
            Digits[Index]= Number % 10;
            Number= Number / 10;
            Index++;
        }
        int Largest= 0;
        int SecondLargest= 0;
        for (int i=0; i<Index; i++){
            if (Digits[i]>Largest){
                SecondLargest= Largest;
                Largest= Digits[i];
            }else if(Digits[i]>SecondLargest && Digits[i] != Largest) SecondLargest= Digits[i];
        }
        Console.WriteLine("Largest Digit: "+Largest);
        Console.WriteLine("Second Largest Digit: "+SecondLargest);
    }
}
