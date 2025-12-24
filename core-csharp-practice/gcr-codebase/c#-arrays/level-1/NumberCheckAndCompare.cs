using System;
class NumberCheckAndCompare{
    static void Main() {
        int[] Numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for(int i = 0; i < Numbers.Length; i++) Numbers[i] = int.Parse(Console.ReadLine());
        for(int i = 0; i < Numbers.Length; i++){
            if(Numbers[i] > 0) {
                if(Numbers[i] % 2 == 0) Console.WriteLine(Numbers[i] + " is a positive even number.");
                else Console.WriteLine(Numbers[i] + " is a positive odd number.");
            }
            else if (Numbers[i] < 0) Console.WriteLine(Numbers[i] + " is a negative number.");
            else Console.WriteLine("The number is zero.");
        }
        if(Numbers[0] == Numbers[Numbers.Length - 1]) Console.WriteLine("First and last elements are equal.");
        else if(Numbers[0] > Numbers[Numbers.Length - 1]) Console.WriteLine("First element is greater than last element.");
        else Console.WriteLine("First element is less than last element.");
    }
}
