using System;
class ArmstrongNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= int.Parse(Console.ReadLine());
        int OriginalNumber =Number;
        int Sum =0;
        while(OriginalNumber != 0){
            int Digit =OriginalNumber%10;
            Sum += (Digit*Digit*Digit);
            OriginalNumber /= 10;
        }
        if (Sum == Number)
            Console.WriteLine("Armstrong Number.");
        else
            Console.WriteLine("Not an Armstrong Number.");
    }
}
