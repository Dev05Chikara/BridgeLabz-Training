using System;
class NumberCheck{
    static bool IsPositive(int Number){
        return Number > 0;
    }
    static bool IsEven(int Number){
        return Number % 2 == 0;
    }
    static int Compare(int A,int B){
        if(A > B) return 1;
        if(A == B) return 0;
        return -1;
    }
    static void Main(){
        int[] Numbers = new int[5];
        for(int i=0;i<5;i++){
			Console.Write("Enter the number:");
            Numbers[i] = Convert.ToInt32(Console.ReadLine());
            if(IsPositive(Numbers[i])) Console.WriteLine(IsEven(Numbers[i]));
            else Console.WriteLine("Negative");
        }
        Console.WriteLine(Compare(Numbers[0],Numbers[4]));
    }
}
