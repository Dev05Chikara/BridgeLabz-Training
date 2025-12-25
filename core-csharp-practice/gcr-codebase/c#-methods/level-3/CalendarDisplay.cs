using System;
class CalendarDisplay{
    static string GetMonthName(int Month){
        string[] Months={"January","February","March","April","May","June","July","August","September","October","November","December"};
        return Months[Month-1];
    }
    static bool IsLeapYear(int Year){
        if(Year%400==0) return true;
        if(Year%100==0) return false;
        return Year%4==0;
    }
    static int GetDaysInMonth(int Month,int Year){
        int[] Days={31,28,31,30,31,30,31,31,30,31,30,31};
        if(Month==2 && IsLeapYear(Year)) return 29;
        return Days[Month-1];
    }
    static int GetFirstDay(int Month,int Year){
        int d=1;
        int y0=Year-(14-Month)/12;
        int x=y0+y0/4-y0/100+y0/400;
        int m0=Month+12*((14-Month)/12)-2;
        int d0=(d+x+(31*m0)/12)%7;
        return d0;
    }
    static void Main(){
        Console.Write("Enter Month: ");
        int Month=int.Parse(Console.ReadLine());
        Console.Write("Enter Year: ");
        int Year=int.Parse(Console.ReadLine());
        Console.WriteLine(GetMonthName(Month)+" "+Year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        int FirstDay=GetFirstDay(Month,Year);
        int Days=GetDaysInMonth(Month,Year);
        for(int i=0;i<FirstDay;i++) Console.Write("    ");
        for(int day=1;day<=Days;day++){
            Console.Write(String.Format("{0,3} ",day));
            if((day+FirstDay)%7==0) Console.WriteLine();
        }
    }
}
