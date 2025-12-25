using System;
class LeapYearCheck{
    static bool IsLeapYear(int Year){
        if(Year < 1582) return false;
        if(Year % 400 == 0) return true;
        if(Year % 100 == 0) return false;
        return Year % 4 == 0;
    }
    static void Main(){
        Console.Write("Enter year: ");
        int Year = Convert.ToInt32(Console.ReadLine());
        if(IsLeapYear(Year)) Console.WriteLine("Leap Year");
        else Console.WriteLine("Not a Leap Year");
    }
}
