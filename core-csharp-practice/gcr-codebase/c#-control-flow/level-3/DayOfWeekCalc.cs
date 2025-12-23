using System;
class DayOfWeekCalc{
    static void Main(string[] args){
        int M = int.Parse(args[0]);
        int D = int.Parse(args[1]);
        int Y = int.Parse(args[2]);
        int Y0 = Y - (14 - M) / 12;
        int X = Y0 + Y0 / 4 - Y0 / 100 + Y0 / 400;
        int M0 = M + 12 * ((14 - M) / 12) - 2;
        int D0 = (D + X + (31 * M0) / 12) % 7;
        Console.WriteLine("Day: " + D0);
    }
}
