using System;
class TimeZones{
	static void ShowTimeZones(){
		DateTimeOffset utcTime = DateTimeOffset.UtcNow;
		TimeZoneInfo GMT = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
		TimeZoneInfo IST = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
		TimeZoneInfo PST = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime, GMT));
		Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, IST));
		Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, PST));
	}
	static void Main(){
		ShowTimeZones();
	}
}
