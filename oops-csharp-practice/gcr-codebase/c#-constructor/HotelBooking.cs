using System;
class HotelBooking{
	private string guestName;
	private string roomType;
	private int nights;
	
	//Default Constructor
	public HotelBooking(){
		guestName= "Guest";
		roomType= "Standard";
		nights= 1;
	}
	
	//Parameterized Constructor
	public HotelBooking(string guestName, string roomType, int nights){
		this.guestName= guestName;
		this.roomType= roomType;
		this.nights= nights;
	}
	
	//Copy Constructor
	public HotelBooking(HotelBooking booking){
		this.guestName= booking.guestName;
		this.roomType= booking.roomType;
		this.nights= booking.nights;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nHotel Booking Details:");
		Console.WriteLine("- Guest Name: "+guestName);
		Console.WriteLine("- Room Type: "+roomType);
		Console.WriteLine("- Nights: "+nights);
	}
}
class Program{
	static void Main(){
		HotelBooking booking1= new HotelBooking();
		HotelBooking booking2= new HotelBooking("Dev Chikara", "Deluxe", 3);
		HotelBooking booking3= new HotelBooking(booking2);
		
		booking1.DisplayDetails();
		booking2.DisplayDetails();
		booking3.DisplayDetails();
	}
}
