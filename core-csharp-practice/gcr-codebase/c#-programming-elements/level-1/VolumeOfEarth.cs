using System;
class VolumeOfEarth{
	static void Main(){
		int RadiusInKm= 6378;
		double RadiusInMiles= RadiusInKm*1.6;
		double VolumeInKm= (4/3) * Math.PI * (Math.Pow(RadiusInKm,3));
		double VolumeInMiles= (4/3) * Math.PI * (Math.Pow(RadiusInMiles,3));
		Console.WriteLine("The volume of earth in cubic kilometers is "+VolumeInKm+" and cubic miles is "+VolumeInMiles);
	}
}