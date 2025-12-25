using System;
class ArmstrongLargest{
    static int CountDigits(int Number){
        int Count = 0;
        while(Number > 0){
            Count++;
            Number /= 10;
        }
        return Count;
    }
    static int[] StoreDigits(int Number){
        int Count = CountDigits(Number);
        int[] Digits = new int[Count];
        for(int i=Count-1;i>=0;i--){
            Digits[i] = Number % 10;
            Number /= 10;
        }
        return Digits;
    }
    static bool IsDuckNumber(int[] Digits){
        for(int i=0;i<Digits.Length;i++){
            if(Digits[i] != 0) return true;
        }
        return false;
    }
    static bool IsArmstrong(int Number,int[] Digits){
        int Sum = 0;
        for(int i=0;i<Digits.Length;i++){
            Sum += (int)Math.Pow(Digits[i],Digits.Length);
        }
        return Sum == Number;
    }
    static int[] FindLargestSecondLargest(int[] Digits){
        int First = Int32.MinValue;
        int Second = Int32.MinValue;
        for(int i=0;i<Digits.Length;i++){
            if(Digits[i] > First){
                Second = First;
                First = Digits[i];
            }else if(Digits[i] > Second && Digits[i] != First){
                Second = Digits[i];
            }
        }
        return new int[]{First,Second};
    }
    static int[] FindSmallestSecondSmallest(int[] Digits){
        int First = Int32.MaxValue;
        int Second = Int32.MaxValue;
        for(int i=0;i<Digits.Length;i++){
            if(Digits[i] < First){
                Second = First;
                First = Digits[i];
            }else if(Digits[i] < Second && Digits[i] != First){
                Second = Digits[i];
            }
        }
        return new int[]{First,Second};
    }
    static void Main(){
        Console.Write("Enter Number: ");
        int Number = int.Parse(Console.ReadLine());
        int[] Digits = StoreDigits(Number);
        Console.WriteLine("Duck Number: "+IsDuckNumber(Digits));
        Console.WriteLine("Armstrong Number: "+IsArmstrong(Number,Digits));
        int[] L = FindLargestSecondLargest(Digits);
        int[] S = FindSmallestSecondSmallest(Digits);
        Console.WriteLine("Largest: "+L[0]+" Second Largest: "+L[1]);
        Console.WriteLine("Smallest: "+S[0]+" Second Smallest: "+S[1]);
    }
}
