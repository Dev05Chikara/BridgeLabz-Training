using System;
class SpringSeason{
    static bool IsSpringSeason(int Month,int Day){
        if((Month == 3 && Day >= 20) || (Month == 4) || (Month == 5) || (Month == 6 && Day <= 20)) return true;
        return false;
    }
    static void Main(){
		Console.Write("Enter the Month: ");
        int Month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Day: ");
		int Day = Convert.ToInt32(Console.ReadLine());
        if(IsSpringSeason(Month,Day)) Console.WriteLine("Its a Spring Season");
        else Console.WriteLine("Not a Spring Season");
    }
}
