using System;
class UnitConvertor{
    public static void ConvertKmToOthers(){
		Console.Write("Enter the length in Km: ");
		double Km = double.Parse(Console.ReadLine());
		if(Km < 0) Console.WriteLine("Enter valid length.");
        else{
			Console.WriteLine(Km*0.621371+" Miles");
			Console.WriteLine(Km*1000+" Meter");
			Console.WriteLine(Km*3280+" Feet");
		}
    }
    public static void ConvertMilesToOthers(){
		Console.Write("Enter the length in Miles: ");
		double Miles = double.Parse(Console.ReadLine());
        if(Miles < 0) Console.WriteLine("Enter valid length.");
		else{
			Console.WriteLine(Miles * 1.60934 + " Km");
			Console.WriteLine(Miles * 1609.34 + " Meters");
			Console.WriteLine(Miles * 5280 + " Feet");
		}
    }
    public static void ConvertMetersToOthers(){
		Console.Write("Enter the length in Meters: ");
		double Meters = double.Parse(Console.ReadLine());
		if(Meters < 0) Console.WriteLine("Enter valid length.");
        else{
			Console.WriteLine(Meters * 0.001 + " Km");
			Console.WriteLine(Meters * 3.28084 + " Feet");
			Console.WriteLine(Meters * 0.000621371 + " Miles");
		}
    }
    public static void ConvertFeetToOthers(){
		Console.Write("Enter the length in Feet: ");
		double Feet = double.Parse(Console.ReadLine());
		if(Feet < 0) Console.WriteLine("Enter valid length.");
        else{
			Console.WriteLine(Feet * 0.3048 + " Meters");
			Console.WriteLine(Feet * 0.0003048 + " Km");
			Console.WriteLine(Feet * 0.000189394 + " Miles");
		}
    }
	static void Main(){
		Console.WriteLine("In Which length you want to enter the length?");
		Console.Write("For: Km(Enter 1), Miles(Enter 2), Meter(Enter 3), Feet(Enter 4): ");
		int Case = int.Parse(Console.ReadLine());
		switch (Case){
			case 1:
				ConvertKmToOthers();
				break;
			case 2:
				ConvertMilesToOthers();
				break;
			case 3:
				ConvertMetersToOthers();
				break;
			case 4:
				ConvertFeetToOthers();
				break;
			default:
                Console.WriteLine("Invalid Choice");
                break;
		}
	}
}
